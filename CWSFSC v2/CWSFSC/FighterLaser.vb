Namespace Fighters
    Public Class FighterLaser
        Implements IFighterWeapons

        Private laserName As String
        Private laserMass As Double
        Private systemType As String
        Private laserBPV As UInt16
        Private damageClass As DamageClass
        Private laserRange As UInt32
        Private EMPRes As String
        Private damCap As String
        Private ECS As String
        Private heatIn As UInt16
        Private heatOut As UInt16
        Private damageTable As DataTable

        Public Sub New()
            laserName = "Nil"
            systemType = "Laser"
            laserMass = 0
            laserBPV = 0
            damageClass = New DamageClass(0, "!"c)
            laserRange = 0
            EMPRes = "Poor"
            damCap = "Poor"
            ECS = "Poor"
            heatIn = 0
            heatOut = 0
            damageTable = New DataTable()
        End Sub

        Public Sub New(ByVal name As String, ByVal mass As Double, ByVal bpv As UInt16, ByVal dt As DataTable, ByVal hi As UInt16,
                       ByVal ho As UInt16, ByVal ran As UInt32, ByVal emr As String, ByVal dc As DamageClass, ByVal damc As String,
                       ByVal ec As String)

            laserName = name
            systemType = "Laser"
            laserMass = mass
            laserBPV = bpv
            damageClass = dc
            laserRange = ran
            EMPRes = emr
            damCap = damc
            ECS = ec
            heatIn = hi
            heatOut = ho
            damageTable = dt
        End Sub

        Public ReadOnly Property BPV As UShort Implements IFighterSystem.BPV
            Get
                Return laserBPV
            End Get
        End Property

        Public Sub BuildDamageTable(ByVal table As DataTable) Implements IFighterWeapons.BuildDamageTable
            If table IsNot Nothing Then
                damageTable = table
            End If
        End Sub

        Public ReadOnly Property DamageCap As String Implements IFighterWeapons.DamageCap
            Get
                Return damCap
            End Get
        End Property

        Public ReadOnly Property ElectronCrossSection As String Implements IFighterWeapons.ElectronCrossSection
            Get
                Return ECS
            End Get
        End Property

        Public ReadOnly Property EMPRest As String Implements IFighterWeapons.EMPRest
            Get
                Return EMPRes
            End Get
        End Property

        Public ReadOnly Property HeadOutput As UShort Implements IFighterWeapons.HeadOutput
            Get
                Return heatOut
            End Get
        End Property

        Public ReadOnly Property HeatInput As UShort Implements IFighterWeapons.HeatInput
            Get
                Return heatIn
            End Get
        End Property

        Public ReadOnly Property Mass As Double Implements IFighterSystem.Mass
            Get
                Return laserMass
            End Get
        End Property

        Public ReadOnly Property Name As String Implements IFighterSystem.Name
            Get
                Return laserName
            End Get
        End Property

        Public ReadOnly Property Type As String Implements IFighterSystem.Type
            Get
                Return systemType
            End Get
        End Property

        Public ReadOnly Property WeaponDamageClass As DamageClass Implements IFighterWeapons.WeaponDamageClass
            Get
                Return damageClass
            End Get
        End Property

        Public ReadOnly Property WeaponRange As UShort Implements IFighterWeapons.WeaponRange
            Get
                Return laserRange
            End Get
        End Property

        Public Function GetInfo() As DataTable Implements IFighterSystem.GetInfo
            Return damageTable
        End Function
    End Class
End Namespace
