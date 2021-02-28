Imports COH.GameContent.Structures.Resources

Namespace GameContent.Structures.Resources.GEO
    Public NotInheritable Class COH_Resource_GEO_PackData_UnPack

#Region "Properties"
        Property TriangleIndices As HelperClasses.COH_Struct_TriangleIndice()
        Property Vertexs As COH_Struct_Vector3()
        Property Normals As COH_Struct_Vector3()
        '//NOT SUPPORTED YET
        Property STS As COH_Struct_Vector2()
        Property STS3 As COH_Struct_Vector2()
        Property Weights As COH_Struct_Weight()
        Property BoneMatIndex As COH_Struct_MaterialIndex()
        Property Reductions As COH_Resource_GenericMesh_Reduction()
        Property ReflectionQuads As COH_Struct_Vector3()
        Property Valid As Boolean = True
#End Region

#Region "Private Properties"
       Private mVersion As Integer
       Private mBlockStarts As Integer
#End Region

#Region "Create New Instances"
        Public Sub New(Version As Integer, ByRef Header As COH_Resource_GEO_ModelHeader, ModelIndex As Integer, DataStarts As Integer, ByRef CurrentReader As COH_BinaryReader)
            mVersion = Version
            mBlockStarts = DataStarts
            Valid = UnPackData(CurrentReader, Header, ModelIndex)
        End Sub
#End Region

#Region "Get PackedData"
        Private Function Retrieve_PackedBuffer(ByRef CurrentReader As COH_BinaryReader, ByRef PackedData As COH_Resource_GEO_PackData) As Byte()
            CurrentReader.Position = mBlockStarts + PackedData.Bytes_Pointer
            If PackedData.PackSize = 0 And PackedData.UnPackSize > 0 Then
                Dim RawBytes As Byte() = CurrentReader.ReadBytes(PackedData.UnPackSize)
                Return RawBytes
            Else
                Dim RawBytes As Byte() = CurrentReader.ReadBytes(PackedData.PackSize)
                Dim DecompresssedRawBytes As Byte() = HelperFunctions.Compression.DecompressBytes(RawBytes)
                Return DecompresssedRawBytes
            End If
        End Function
        Private Function ReadBits(ByRef buffer() As Byte, bufferoffset As Integer, ByVal bit_offset As UInteger) As Byte
            Dim [byte] As Byte = buffer(bufferoffset + (bit_offset \ 8))
            Dim bit_offset_in_byte As UInteger = bit_offset Mod 8
            Return ([byte] >> CInt(bit_offset_in_byte)) And 3
        End Function
        Private Function Retrieve_DeltaCodes(ByRef Buffer As Byte()) As List(Of Integer) '//Work around for now, for Bit Shifting being a pain in the ass
            Dim tEMP As String() = HelperFunctions.Bits.Convert_ToStringArray(Buffer, COH_Supported_BinaryByteOrder.LittleEndian)
            Dim Codes As New List(Of String)
            For X = 0 To tEMP.Count - 1
                Codes.Add(tEMP(X).Substring(6, 2))
                Codes.Add(tEMP(X).Substring(4, 2))
                Codes.Add(tEMP(X).Substring(2, 2))
                Codes.Add(tEMP(X).Substring(0, 2))
            Next
            Dim CodeV As New List(Of Integer)
            For X = 0 To Codes.Count - 1
                Select Case Codes(X)
                    Case "00"
                        CodeV.Add(0)
                    Case "01"
                        CodeV.Add(1)
                    Case "10"
                        CodeV.Add(2)
                    Case "11"
                        CodeV.Add(3)
                End Select
            Next
            Return CodeV
        End Function
        Private Function Split_DeltaBuffers(ByRef Buffer As Byte(), NumberItems As Integer, Stride As Integer, ByRef BITBuffer As Byte(), ByRef ScaleByte As Byte, ByRef ValueBuffer As Byte()) As Boolean
            Dim Number_Bits As UInt32 = (2 * NumberItems * Stride) '684
            Dim SectionByteSize_Bits As UInteger = Math.Ceiling((Number_Bits) / 8) 'Round up instead of using +7
            BITBuffer = New Byte(SectionByteSize_Bits - 1) {}
            Array.ConstrainedCopy(Buffer, 0, BITBuffer, 0, SectionByteSize_Bits)
            ScaleByte = Buffer(SectionByteSize_Bits)
            Dim SizeValueSection = Buffer.Length - (SectionByteSize_Bits + 1)
            ValueBuffer = New Byte(SizeValueSection - 1) {}
            Array.ConstrainedCopy(Buffer, SectionByteSize_Bits + 1, ValueBuffer, 0, SizeValueSection)
            Return True
        End Function
#End Region

#Region "UnPack"
        Private Function UnPackData(ByRef CurrentReader As COH_BinaryReader, ByRef Header As COH_Resource_GEO_ModelHeader, ModelIndex As Integer) As Boolean
            TriangleIndices = GEO_Unpack_TriangleIndices(Retrieve_PackedBuffer(CurrentReader, Header.Models(ModelIndex).PackedData.Triangles), Header.Models(ModelIndex).TriangleCount)
            Vertexs = GEO_Unpack_Floats_Vector3(Retrieve_PackedBuffer(CurrentReader, Header.Models(ModelIndex).PackedData.Vertices), Header.Models(ModelIndex).VertexCount)
            Normals = GEO_Unpack_Floats_Vector3(Retrieve_PackedBuffer(CurrentReader, Header.Models(ModelIndex).PackedData.Normals), Header.Models(ModelIndex).VertexCount)
            STS = GEO_Unpack_Floats_Vector2(Retrieve_PackedBuffer(CurrentReader, Header.Models(ModelIndex).PackedData.sts), Header.Models(ModelIndex).VertexCount)

            Dim WeightBytes = Retrieve_PackedBuffer(CurrentReader, Header.Models(ModelIndex).PackedData.Weights)
            If WeightBytes Is Nothing OrElse WeightBytes.Length = 0 Then
                Weights = New COH_Struct_Weight() {}
            Else
                Weights = New COH_Struct_Weight(Vertexs.Count - 1) {}
                For i = 0 To Vertexs.Count - 1
                    Weights(i) = New COH_Struct_Weight
                    Weights(i).W1 = WeightBytes(i) * 1.0F / 255.0F
                    Weights(i).W2 = 1.0F - Weights(i).W1
                Next i
            End If

            Dim MaterialIndexBytes = Retrieve_PackedBuffer(CurrentReader, Header.Models(ModelIndex).PackedData.matidxs)
            If MaterialIndexBytes Is Nothing OrElse MaterialIndexBytes.Length = 0 Then
                BoneMatIndex = New COH_Struct_MaterialIndex() {}
            Else
                BoneMatIndex = New COH_Struct_MaterialIndex(Vertexs.Count - 1) {}
                For i = 0 To Vertexs.Count - 1
                    BoneMatIndex(i) = New COH_Struct_MaterialIndex
                    BoneMatIndex(i).Pos1 = MaterialIndexBytes(i * 2 + 0)
                    BoneMatIndex(i).Pos2 = MaterialIndexBytes(i * 2 + 1)
                Next i
            End If
            Return True
        End Function
        Private Function Determine_Scale(ByRef ScaleByte As Byte) As Single
            Dim Float_Scale As Single = CSng(1 << ScaleByte)
            Dim scale As Single = 1.0F
            If Float_Scale <> 0.0F Then
                scale = 1.0F / Float_Scale
            End If
            Return scale
        End Function
        Private Function GEO_Unpack_Floats_Vector2(ByRef Buffer As Byte(), NumberItems As Integer) As COH_Struct_Vector2()
            Dim Stride As Integer = 2
            If Buffer.Count = 0 Then Return New COH_Struct_Vector2() {}
            Dim BITS As Byte() = Nothing, Values As Byte() = Nothing, ScaleByte As Byte, Scale As Single = 1.0F
            Split_DeltaBuffers(Buffer, NumberItems, Stride, BITS, ScaleByte, Values)
            Scale = Determine_Scale(ScaleByte)

            Dim CurrentByteIndex As Integer = 0
            Dim Results As COH_Struct_Vector2() = New COH_Struct_Vector2(NumberItems - 1) {}
            Dim CodeV As List(Of Integer) = Retrieve_DeltaCodes(BITS)
            Dim CodeIndex As Integer = 0, DeltaByte As Integer = 0
            Dim CurrentItem() As Single = New Single(Stride - 1) {}
            Dim Amount1 As Integer = 127 'or 1/2 byte - rounded down
            Dim Amount2 As Integer = 32767 '//Int16.MaxValue or 1/2 UINT16 rounded down
            For x = 0 To NumberItems - 1
                For V = 0 To Stride - 1
                    Dim DeltaFloat As Single = 0
                    Dim CODE As Integer = CodeV(CodeIndex) : CodeIndex += 1
                    Select Case CODE'185
                        Case 0
                            DeltaByte = 0
                        Case 1
                            DeltaByte = Values(CurrentByteIndex)
                            DeltaByte -= Amount1 : CurrentByteIndex += 1
                        Case 2
                            'Dim Test As Integer = (CSng(Values(CurrentByteIndex)) Or (CSng(Values(CurrentByteIndex + 1))) << 8) - &H7FFF
                            DeltaByte = BitConverter.ToUInt16(Values, CurrentByteIndex) '//INT16 SEEMS TO BREAK
                            DeltaByte -= Amount2 : CurrentByteIndex += 2
                        Case 3
                            DeltaFloat = BitConverter.ToSingle(Values, CurrentByteIndex)
                            CurrentByteIndex += 4
                    End Select
                    If CODE <> 3 Then DeltaFloat = DeltaByte * Scale
                    CurrentItem(V) += DeltaFloat
                Next
                Results(x) = New COH_Struct_Vector2(CurrentItem)
            Next
            Return Results
        End Function
        Private Function GEO_Unpack_Floats_Vector3(ByRef Buffer As Byte(), NumberItems As Integer) As COH_Struct_Vector3()
            Dim Stride As Integer = 3
            If Buffer.Count = 0 Then Return New COH_Struct_Vector3() {}
            Dim BITS As Byte() = Nothing, Values As Byte() = Nothing, ScaleByte As Byte, Scale As Single = 1.0F
            Split_DeltaBuffers(Buffer, NumberItems, Stride, BITS, ScaleByte, Values)
            Scale = Determine_Scale(ScaleByte)

            Dim CurrentByteIndex As Integer = 0
            Dim Results As COH_Struct_Vector3() = New COH_Struct_Vector3(NumberItems - 1) {}
            Dim CodeV As List(Of Integer) = Retrieve_DeltaCodes(BITS)
            Dim CodeIndex As Integer = 0, DeltaByte As Integer = 0
            Dim CurrentItem() As Single = New Single(Stride - 1) {}
            Dim Amount1 As Integer = 127 'or 1/2 byte - rounded down
            Dim Amount2 As Integer = 32767 '//Int16.MaxValue or 1/2 UINT16 rounded down
            For x = 0 To NumberItems - 1
                For V = 0 To Stride - 1
                    Dim DeltaFloat As Single = 0
                    Dim CODE As Integer = CodeV(CodeIndex) : CodeIndex += 1
                    Select Case CODE'185
                        Case 0
                            DeltaByte = 0
                        Case 1
                            DeltaByte = Values(CurrentByteIndex)
                            DeltaByte -= Amount1 : CurrentByteIndex += 1
                        Case 2
                            'Dim Test As Integer = (CSng(Values(CurrentByteIndex)) Or (CSng(Values(CurrentByteIndex + 1))) << 8) - &H7FFF
                            DeltaByte = BitConverter.ToUInt16(Values, CurrentByteIndex) '//INT16 SEEMS TO BREAK
                            DeltaByte -= Amount2 : CurrentByteIndex += 2
                        Case 3
                            DeltaFloat = BitConverter.ToSingle(Values, CurrentByteIndex)
                            CurrentByteIndex += 4
                    End Select
                    If CODE <> 3 Then DeltaFloat = DeltaByte * Scale
                    CurrentItem(V) += DeltaFloat
                Next
                Results(x) = New COH_Struct_Vector3(CurrentItem)
            Next
            Return Results
        End Function
        Private Function GEO_Unpack_TriangleIndices(ByRef Buffer As Byte(), NumberItems As Integer) As COH_Struct_TriangleIndice()
            If (Buffer Is Nothing) OrElse Buffer.Count = 0 Then Return New COH_Struct_TriangleIndice() {}
            Dim BITS As Byte() = Nothing, Values As Byte() = Nothing, ScaleByte As Byte, Scale As Single = 1.0F
            Split_DeltaBuffers(Buffer, NumberItems, 3, BITS, ScaleByte, Values)
            Scale = Determine_Scale(ScaleByte)

            Dim CurrentByteIndex As Integer = 0
            Dim Results As COH_Struct_TriangleIndice() = New COH_Struct_TriangleIndice(NumberItems - 1) {} 'CurrentItem
            Dim CodeV As List(Of Integer) = Retrieve_DeltaCodes(BITS)
            Dim CodeIndex As Integer = 0, DeltaByte As Integer = 0
            Dim CurrentItem() As Integer = New Integer(3 - 1) {}
            Dim Amount1 As Integer = 127
            Dim Amount2 As Integer = 32767

            For x = 0 To NumberItems - 1
                For V = 0 To 2
                    Dim CODE As Integer = CodeV(CodeIndex) : CodeIndex += 1
                    Select Case CODE'185
                        Case 0
                            DeltaByte = 0
                        Case 1
                            DeltaByte = Values(CurrentByteIndex) - Amount1 : CurrentByteIndex += 1
                        Case 2
                            DeltaByte = BitConverter.ToUInt16(Values, CurrentByteIndex) - Amount2 : CurrentByteIndex += 2
                        Case 3
                            DeltaByte = BitConverter.ToInt32(Values, CurrentByteIndex) : CurrentByteIndex += 4
                        Case Else
                            DeltaByte = 0
                    End Select
                    CurrentItem(V) += CInt(DeltaByte + 1)
                Next
                Results(x) = New COH_Struct_TriangleIndice(CurrentItem)
            Next
            Return Results
        End Function
#End Region

#Region "Testing"
        Private Function Convert_ToVector2(ByRef Buffer As Byte()) As COH_Struct_Vector2()
            Dim Result As COH_Struct_Vector2() = New COH_Struct_Vector2((Buffer.Length / 2) - 1) {}
            Dim VIndex As Integer = 0
            For X = 0 To Buffer.Count - 1 Step 2
                Result(VIndex) = New COH_Struct_Vector2(Convert.ToSingle(Buffer(X)), Convert.ToSingle(Buffer(X + 1)))
            Next
            Return Result
        End Function

#End Region


    End Class
End Namespace