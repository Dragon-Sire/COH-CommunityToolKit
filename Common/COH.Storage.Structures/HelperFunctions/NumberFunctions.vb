Namespace HelperFunctions.DateTimeFunctions
    <HideModuleName> Public Module NumberFunctions
        Public Function Convert_Uint32Value_To_DateTime(Value As UInt32) As DateTime
            Dim sTimeSpan As TimeSpan = TimeSpan.FromTicks(Value * TimeSpan.TicksPerSecond)
            Dim sTimeSpan2 As New DateTime(1970, 1, 1)
            Return sTimeSpan2.Add(sTimeSpan)
        End Function
        Public Function Convert_DateTime_to_Uint32Value(TheDate As DateTime) As UInt32
            Dim sTimeSpan2 As New DateTime(1970, 1, 1)
            Dim Result As Long = (TheDate.Ticks - sTimeSpan2.Ticks) / TimeSpan.TicksPerSecond
            Return Result
        End Function


        Public Function Convert_Uint32Value_To_DateTime_From2000(Value As UInt32) As DateTime
            Dim sTimeSpan As TimeSpan = TimeSpan.FromTicks(Value * TimeSpan.TicksPerSecond)
            Dim sTimeSpan2 As New DateTime(2000, 1, 1)
            Return sTimeSpan2.Add(sTimeSpan)
        End Function
        Public Function Convert_DateTime_to_Uint32Value_From2000(TheDate As DateTime) As UInt32
            Dim sTimeSpan2 As New DateTime(2000, 1, 1)
            Dim Result As Long = (TheDate.Ticks - sTimeSpan2.Ticks) / TimeSpan.TicksPerSecond
            Return Result
        End Function
    End Module
End Namespace