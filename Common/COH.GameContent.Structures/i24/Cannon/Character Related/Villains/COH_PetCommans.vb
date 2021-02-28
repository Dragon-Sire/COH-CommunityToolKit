Namespace GameContent.Structures.Enemies
    Public Class COH_PetCommands
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Pet Commands"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Passive As String()
            Get
                Return mPassive
            End Get
            Set(value As String())
                mPassive = value
            End Set
        End Property
        Property Defensive As String()
            Get
                Return mDefensive
            End Get
            Set(value As String())
                mDefensive = value
            End Set
        End Property
        Property Aggressive As String()
            Get
                Return mAggressive
            End Get
            Set(value As String())
                mAggressive = value
            End Set
        End Property
        Property AttackTarget As String()
            Get
                Return mAttackTarget
            End Get
            Set(value As String())
                mAttackTarget = value
            End Set
        End Property
        Property AttackNoTarget As String()
            Get
                Return mAttackNoTarget
            End Get
            Set(value As String())
                mAttackNoTarget = value
            End Set
        End Property
        Property StayHere As String()
            Get
                Return mStayHere
            End Get
            Set(value As String())
                mStayHere = value
            End Set
        End Property
        Property UsePower As String()
            Get
                Return mUsePower
            End Get
            Set(value As String())
                mUsePower = value
            End Set
        End Property
        Property UsePowerNone As String()
            Get
                Return mUsePowerNone
            End Get
            Set(value As String())
                mUsePowerNone = value
            End Set
        End Property
        Property FollowMe As String()
            Get
                Return mFollowMe
            End Get
            Set(value As String())
                mFollowMe = value
            End Set
        End Property
        Property GotoSpot As String()
            Get
                Return mGotoSpot
            End Get
            Set(value As String())
                mGotoSpot = value
            End Set
        End Property
        Property Dismiss As String()
            Get
                Return mDismiss
            End Get
            Set(value As String())
                mDismiss = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mPassive As String()
       Private mDefensive As String()
       Private mAggressive As String()
       Private mAttackTarget As String()
       Private mAttackNoTarget As String()
       Private mStayHere As String()
       Private mUsePower As String()
       Private mUsePowerNone As String()
       Private mFollowMe As String()
       Private mGotoSpot As String()
       Private mDismiss As String()
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mPassive = New String() {}
            mDefensive = New String() {}
            mAggressive = New String() {}
            mAttackTarget = New String() {}
            mAttackNoTarget = New String() {}
            mStayHere = New String() {}
            mUsePower = New String() {}
            mUsePowerNone = New String() {}
            mFollowMe = New String() {}
            mGotoSpot = New String() {}
            mDismiss = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PetCommands
            Dim Result As COH_PetCommands = New COH_PetCommands
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mPassive = mPassive.CloneTheStrings
                .mDefensive = mDefensive.CloneTheStrings
                .mAggressive = mAggressive.CloneTheStrings
                .mAttackTarget = mAttackTarget.CloneTheStrings
                .mAttackNoTarget = mAttackNoTarget.CloneTheStrings
                .mStayHere = mStayHere.CloneTheStrings
                .mUsePower = mUsePower.CloneTheStrings
                .mUsePowerNone = mUsePowerNone.CloneTheStrings
                .mFollowMe = mFollowMe.CloneTheStrings
                .mGotoSpot = mGotoSpot.CloneTheStrings
                .mDismiss = mDismiss.CloneTheStrings
            End With
            Return Result
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_StringArray(mPassive)
            CurrentWriter.Write_CrypticS_StringArray(mDefensive)
            CurrentWriter.Write_CrypticS_StringArray(mAggressive)
            CurrentWriter.Write_CrypticS_StringArray(mAttackTarget)
            CurrentWriter.Write_CrypticS_StringArray(mAttackNoTarget)
            CurrentWriter.Write_CrypticS_StringArray(mStayHere)
            CurrentWriter.Write_CrypticS_StringArray(mUsePower)
            CurrentWriter.Write_CrypticS_StringArray(mUsePowerNone)
            CurrentWriter.Write_CrypticS_StringArray(mFollowMe)
            CurrentWriter.Write_CrypticS_StringArray(mGotoSpot)
            CurrentWriter.Write_CrypticS_StringArray(mDismiss)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mPassive = CurrentReader.Read_CrypticS_StringArray()
            mDefensive = CurrentReader.Read_CrypticS_StringArray()
            mAggressive = CurrentReader.Read_CrypticS_StringArray()
            mAttackTarget = CurrentReader.Read_CrypticS_StringArray()
            mAttackNoTarget = CurrentReader.Read_CrypticS_StringArray()
            mStayHere = CurrentReader.Read_CrypticS_StringArray()
            mUsePower = CurrentReader.Read_CrypticS_StringArray()
            mUsePowerNone = CurrentReader.Read_CrypticS_StringArray()
            mFollowMe = CurrentReader.Read_CrypticS_StringArray()
            mGotoSpot = CurrentReader.Read_CrypticS_StringArray()
            mDismiss = CurrentReader.Read_CrypticS_StringArray()
            Return True
        End Function
#End Region


    End Class
End Namespace