Function Invoke-DelegateOnJsonNode {
    [CmdletBinding()]
    param(
        [System.Management.Automation.ScriptBlock] $Delegate
		
    )
    $Delegate.Invoke()
}

Function Invoke-DelegateOnJsonNodeWithProperty {
    [CmdletBinding()]
    param(
        [string] $PropertyName,
        [System.Management.Automation.ScriptBlock] $Delegate,
        [object] $JsonObject
    )

    # 
    if ($null -eq $JsonObject) {
        return $null
    }

    # 
    try {
        if ($JsonObject.Keys -contains $PropertyName) {
            $Delegate.Invoke($PropertyName, $JsonObject)
        }
    }
    catch {
        Write-Host $_
        Write-Host $JsonObject
        $Delegate.Invoke($PropertyName, $JsonObject)
    }
    
    # 
    # if ($null -eq $JsonObject.Values -and
    #     $JsonObject.GetType().ToString() -ne 'System.Object[]') {
    #     return $null
    # }
    if ($null -eq $JsonObject.Values) {
        # if ($JsonObject.GetType().ToString() -ne 'System.Object[]') {
        #     return $null
        # }
        switch ($JsonObject.GetType().ToString()) {
            { 'System.Object[]', 'Object[]', 'System.Object', 'Object' -contains $_ } { }
            default { return $null }
        }
    }

    # 
    $JsonObject.Values | ForEach-Object {
        Invoke-DelegateOnJsonNodeWithProperty -PropertyName $PropertyName -Delegate $Delegate -JsonObject $_
    }
}