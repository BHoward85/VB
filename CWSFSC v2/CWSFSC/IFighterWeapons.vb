Namespace Fighters
    Public Interface IFighterWeapons
        Inherits IFighterSystem

        ReadOnly Property WeaponDamageClass As DamageClass

        ReadOnly Property WeaponRange As UInt16

        ReadOnly Property DamageCap As String

        ReadOnly Property EMPRest As String

        ReadOnly Property ElectronCrossSection As String

        ReadOnly Property HeatInput As UInt16

        ReadOnly Property HeadOutput As UInt16

        Sub BuildDamageTable(ByVal table As DataTable)
    End Interface
End Namespace