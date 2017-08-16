Namespace Fighters
    Public Class FighterFCS
        Implements IFighterSystem

        Private FCSName As String
        Private FCSMass As Double
        Private FCSBPV As UInt16
        Private systemType As String
        Private FCSPoint As Byte
        Private FCSRange As UInt16
        Private targetCone As String
        Private ECMRes As String
        Private EMPRes As String
        Private damageCap As String

        Public Sub New()
            FCSName = "Nil"
            systemType = "FCS"
            FCSMass = 0
            FCSBPV = 0
            FCSPoint = 0
            FCSRange = 0
            targetCone = "F"
            ECMRes = "Poor"
            EMPRes = "Poor"
            damageCap = "Poor"
        End Sub

        Public Sub New(ByVal name As String, ByVal mass As Double, ByVal bpv As UInt16, ByVal fp As Byte, fr As UInt16, _
                       ByVal tc As String, ByVal er As String, ByVal epr As String, ByVal dc As String)

            FCSName = name
            systemType = "FCS"
            FCSMass = mass
            FCSBPV = bpv
            FCSPoint = fp
            FCSRange = fr
            targetCone = tc
            ECMRes = er
            EMPRes = epr
            damageCap = dc
        End Sub

        Public ReadOnly Property BPV As UShort Implements IFighterSystem.BPV
            Get
                Return FCSBPV
            End Get
        End Property

        Public ReadOnly Property Mass As Double Implements IFighterSystem.Mass
            Get
                Return FCSMass
            End Get
        End Property

        Public ReadOnly Property Name As String Implements IFighterSystem.Name
            Get
                Return FCSName
            End Get
        End Property

        Public ReadOnly Property Type As String Implements IFighterSystem.Type
            Get
                Return systemType
            End Get
        End Property

        Public Function GetInfo() As DataTable Implements IFighterSystem.GetInfo
            Dim DT As DataTable = New DataTable

            DT.Columns.Add("FCS Point")
            DT.Columns.Add("FCS Range")
            DT.Columns.Add("Target Cone")
            DT.Columns.Add("ECM Res")
            DT.Columns.Add("EMP Res")
            DT.Columns.Add("Damage Cap")

            DT.Rows.Add(FCSPoint, FCSRange, targetCone, ECMRes, EMPRes, damageCap)

            Return DT
        End Function
    End Class
End Namespace
