Imports System.ComponentModel

Namespace Internal.DeveloperOptions
    <HideModuleName()> Public Module COH_Internal_CompilingOptions

#Const DS_DeveloperMode = 1

#If DS_DeveloperMode = 0 Then 'No Developer Mode
        Public Const COH_DeveloperMode_ShowPrivate As EditorBrowsableState = EditorBrowsableState.Never
        Public Const COH_DeveloperMode_AllowFeature As Boolean = False
        Public Const COH_DeveloperMode_AllowGridFull As Boolean = False
        Public Const COH_DeveloperMode_LogDebug As Boolean = False
#ElseIf DS_DeveloperMode = 1 Then 'General Debug Info
        Public Const COH_DeveloperMode_ShowPrivate As EditorBrowsableState = EditorBrowsableState.Never
        Public Const COH_DeveloperMode_AllowEdit As Boolean = True
        Public Const COH_DeveloperMode_AllowFeature As Boolean = True
        Public Const COH_DeveloperMode_LogDebug As Boolean = False
#ElseIf DS_DeveloperMode = 2 Then 'All Details
        Public Const COH_DeveloperMode_ShowPrivate As EditorBrowsableState = EditorBrowsableState.Always
        Public Const DS_DeveloperMode_LogDebug As Boolean = True
#End If

        Public Const CharacterAttributesSize = 460

    End Module
End Namespace