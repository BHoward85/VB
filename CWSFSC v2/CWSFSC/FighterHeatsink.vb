Namespace Fighters
    Public Class FighterHeatsink
        Implements IFighterSystem

        Private heatsinkName As String
        Private heatsinkMass As Double
        Private heatsinkBPV As UInt16
        Private systemType As String
        Private heatCap As UInt32
        Private coolingRate As UInt16
        Private forceCoolingRate As UInt16
        Private damageCap As String

        Public Sub New()
            heatsinkName = "Nil"
            systemType = "Heatsink"
            heatsinkMass = 0
            heatsinkBPV = 0
            heatCap = 0
            coolingRate = 0
            forceCoolingRate = 0
            damageCap = "Poor"
        End Sub

        Public Sub New(ByVal name As String, ByVal mass As Double, ByVal bpv As UInt16, ByVal hc As UInt16, _
                       ByVal cr As UInt16, ByVal fcr As UInt16, ByVal dc As String)
            heatsinkName = name
            systemType = "Heatsink"
            heatsinkMass = mass
            heatsinkBPV = bpv
            heatCap = hc
            coolingRate = cr
            forceCoolingRate = fcr
            damageCap = dc
        End Sub

        Public ReadOnly Property BPV As UShort Implements IFighterSystem.BPV
            Get
                Return heatsinkBPV
            End Get
        End Property

        Public ReadOnly Property Mass As Double Implements IFighterSystem.Mass
            Get
                Return heatsinkMass
            End Get
        End Property

        Public ReadOnly Property Name As String Implements IFighterSystem.Name
            Get
                Return heatsinkName
            End Get
        End Property

        Public ReadOnly Property Type As String Implements IFighterSystem.Type
            Get
                Return systemType
            End Get
        End Property

        Public Function GetInfo() As DataTable Implements IFighterSystem.GetInfo
            Dim DT As DataTable = New DataTable

            DT.Columns.Add("Heat Cap")
            DT.Columns.Add("Cooling Rate")
            DT.Columns.Add("Force Cooling Rate")
            DT.Columns.Add("Damage Cap")

            DT.Rows.Add(heatCap, coolingRate, forceCoolingRate, damageCap)

            Return DT
        End Function
    End Class
End Namespace
