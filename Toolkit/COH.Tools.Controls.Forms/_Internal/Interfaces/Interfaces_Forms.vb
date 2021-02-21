﻿Imports COH.GameContent.Enums

Namespace Interfaces
    Public Interface COH_ParentFormInterface
        Function AvailableClientArea() As Rectangle
    End Interface

    Public Interface I_Support_ModdableContent
        Sub LinkControllers(ByRef TheContentController As ISupport_MasterController)
        Sub LoadContent(TheType As COH_ProjectContent, FileName As String)
    End Interface
End Namespace