Namespace Fighters
    Public Class FighterEngines
        Implements IFighterSystem

        Private engineName As String
        Private engineMass As Double
        Private engineBPV As UInt16
        Private systemType As String
        Private standardThrust As UInt32
        Private maxThrust As UInt32
        Private cruiseSpeed As Byte
        Private overBoostSpeed As Byte
        Private heatOutput As UInt16
        Private heatInput As UInt16
        Private EMPRes As String
        Private damageCap As String


        Public Sub New()
            engineName = "Nil"
            systemType = "Engine"
            engineBPV = 0
            engineMass = 0
            standardThrust = 0
            maxThrust = 0
            cruiseSpeed = 0
            overBoostSpeed = 0
            heatInput = 0
            heatOutput = 0
            EMPRes = "Poor"
            damageCap = "Poor"
        End Sub

        Public Sub New(ByVal name As String, ByVal bpv As UInt16, ByVal mass As Double, ByVal st As UInt32, _
                ByVal mt As UInt32, ByVal cs As Byte, ByVal obs As Byte, ByVal ho As UInt16, ByVal hi As UInt16, ByVal er As String, ByVal dc As String)

            engineName = name
            systemType = "Engine"
            engineBPV = bpv
            engineMass = mass
            standardThrust = st
            maxThrust = mt
            cruiseSpeed = cs
            overBoostSpeed = obs
            heatInput = hi
            heatOutput = ho
            EMPRes = er
            damageCap = dc
        End Sub

        Public ReadOnly Property BPV As UShort Implements IFighterSystem.BPV
            Get
                Return engineBPV
            End Get
        End Property

        Public ReadOnly Property Mass As Double Implements IFighterSystem.Mass
            Get
                Return engineMass
            End Get
        End Property

        Public ReadOnly Property Name As String Implements IFighterSystem.Name
            Get
                Return engineName
            End Get
        End Property

        Public ReadOnly Property Type As String Implements IFighterSystem.Type
            Get
                Return systemType
            End Get
        End Property

        Public Function GetInfo() As DataTable Implements IFighterSystem.GetInfo
            Dim DT As DataTable = New DataTable

            DT.Columns.Add("Standard Thrust")
            DT.Columns.Add("Max Thrust")
            DT.Columns.Add("Cruise Speed")
            DT.Columns.Add("Over Boost Speed")
            DT.Columns.Add("Heat Output")
            DT.Columns.Add("Heat Input")
            DT.Columns.Add("EMP Res")
            DT.Columns.Add("Damage Cap")

            DT.Rows.Add(standardThrust, maxThrust, cruiseSpeed, overBoostSpeed, heatOutput, heatInput, EMPRes, damageCap)

            Return DT
        End Function
    End Class
End Namespace
