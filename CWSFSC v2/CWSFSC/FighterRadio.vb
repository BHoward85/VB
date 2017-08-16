Namespace Fighters
    Public Class FighterRadio
        Implements IFighterSystem

        Private radioName As String
        Private radioMass As Double
        Private radioBPV As UInt16
        Private systemType As String
        Private radioRange As UInt16
        Private radioBandWidth As UInt16
        Private radioTransferRate As UInt16
        Private EWRest As String
        Private EMPRes As String
        Private damageCap As String

        Public Sub New()
            radioName = "Nil"
            systemType = "Radio"
            radioMass = 0
            radioBPV = 0
            radioRange = 0
            radioBandWidth = 0
            radioTransferRate = 0
            EWRest = "Poor"
            EMPRes = "Poor"
            damageCap = "Poor"
        End Sub

        Public Sub New(ByVal name As String, ByVal mass As Double, ByVal bpv As UInt16, ByVal ran As UInt16, ByVal bw As UInt16, ByVal tr As UInt16, _
                       ByVal ewr As String, ByVal empr As String, ByVal dc As String)

            radioName = name
            systemType = "Radio"
            radioMass = mass
            radioBPV = bpv
            radioRange = ran
            radioBandWidth = bw
            radioTransferRate = tr
            EWRest = ewr
            EMPRes = empr
            damageCap = dc
        End Sub

        Public ReadOnly Property BPV As UShort Implements IFighterSystem.BPV
            Get
                Return radioBPV
            End Get
        End Property

        Public ReadOnly Property Mass As Double Implements IFighterSystem.Mass
            Get
                Return radioMass
            End Get
        End Property

        Public ReadOnly Property Name As String Implements IFighterSystem.Name
            Get
                Return radioName
            End Get
        End Property

        Public ReadOnly Property Type As String Implements IFighterSystem.Type
            Get
                Return systemType
            End Get
        End Property

        Public Function GetInfo() As DataTable Implements IFighterSystem.GetInfo
            Dim DT As DataTable = New DataTable

            DT.Columns.Add("Range")
            DT.Columns.Add("Band Width")
            DT.Columns.Add("Transfer Rate")
            DT.Columns.Add("EW Rest")
            DT.Columns.Add("EMP Rest")
            DT.Columns.Add("Damage Cap")

            DT.Rows.Add(radioRange, radioBandWidth, radioTransferRate, EWRest, EMPRes, damageCap)

            Return DT
        End Function
    End Class
End Namespace
