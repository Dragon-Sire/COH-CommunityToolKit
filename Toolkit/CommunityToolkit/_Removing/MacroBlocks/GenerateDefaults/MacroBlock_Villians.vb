Namespace MacroBlocks
    Partial Public NotInheritable Class COH_MacroBlock

#Region "Generate Default Files"
        Public Shared Function Generate_DefaultFiles() As List(Of COH_MacroBlock)
            Dim Result As New List(Of COH_MacroBlock)
            Result.Add(Generate_DefaultFile_Villians())
            Return Result
        End Function
#End Region

#Region "Individual Files"
        Private Shared Function Generate_DefaultFile_Villians() As COH_MacroBlock
            Dim Result As New COH_MacroBlock("Villians", "Cryptic Design Villians")
            Result.Details.Add(New MacroBlock_Detail("Generate Villians", "GenerateVillains", "Generate data file for this villain file.") With {.Bar = True})
            Result.Details.Add(New MacroBlock_Detail("Generate Villians Page", "GeneratePageVillains", "Generate data file for this villain page file.") With {.Bar = True})
            Result.Details.Add(New MacroBlock_Detail("New Villain File", "NewVillianFile", "Create a new villain file") With {.Bar = True})
            Result.Details.Add(New MacroBlock_Detail("New Villain Group", "NewVillainGroup", "Create New Villain Group") With {.Bar = False})
            Result.Details.Add(New MacroBlock_Detail("New Villain Def", "NewVillainDef", "Add new villain def block to existing villain group.") With {.Bar = False})
            Result.Details.Add(New MacroBlock_Detail("New Villain Def Level Block", "NewVillainLevel", "Add new level block to an exisiting villain def") With {.Bar = False})
            Result.Details.Add(New MacroBlock_Detail("Villain Flags", "NewVillainIgnoreCombatMods", "") With {.Bar = False, .Name_SubClass = "Ignore Combat Mods"})
            Result.Details.Add(New MacroBlock_Detail("Comment", "NewVillainComment", "") With {.Bar = False})
            Result.Details.Add(New MacroBlock_Detail("Convert Old Villain File", "SetupVillainFile", "") With {.Bar = False})
            Result.Details.Add(New MacroBlock_Detail("Delete Row", "DeleteCurrentRow", "Delete the current row") With {.Bar = True})
            Return Result
        End Function
#End Region

#Region "Write XML Files"
        Public Shared Sub WriteToXML_DefaultFiles(Folder As String)
            Dim Result = Generate_DefaultFiles()
            WriteToXML(Result, Folder)
        End Sub
        Public Shared Sub WriteToXML(ByRef Sources As List(Of COH_MacroBlock), Folder As String)
            Dim ExportFile As String = Nothing
            For Each Source In Sources
                ExportFile = IO.Path.Combine(Folder, Source.MenuName & ".xml")
                Export_XMLFile(ExportFile, Source)
            Next
        End Sub
#End Region


#Region "Import/Export"
        Public Shared Function Export_XMLFile(Filepath As String, Source As COH_MacroBlock, Optional ShowMessage As Boolean = False) As Boolean
            Dim Result As String = ""
            Try
                Dim Writer As New IO.StreamWriter(Filepath)
                Dim x As New Xml.Serialization.XmlSerializer(Source.GetType)
                x.Serialize(Writer, Source)
                Writer.WriteLine()
                Result = Writer.ToString
                Writer.Dispose()
            Catch ex As Exception
                '//.ShowError(ex.ToString)
            End Try
            '//If ShowMessage = True Then ShowMessage("Export Complete.")
            Return True
        End Function
        Public Shared Function Import_XMLFile(Filepath As String, Optional ShowMessage As Boolean = False) As COH_MacroBlock
            Dim Result As New COH_MacroBlock
            If IO.File.Exists(Filepath) = True Then
                Try
                    Dim Reader As New IO.StreamReader(Filepath)
                    Dim x As New Xml.Serialization.XmlSerializer(Result.GetType)
                    Result = x.Deserialize(Reader)
                    Reader.Close()
                Catch ex As Exception
                    '//.ShowError(ex.ToString)
                End Try
            End If
            '//If ShowMessage = True Then ShowMessage("Import Complete.")
            Return Result
        End Function
#End Region
    End Class
End Namespace