Namespace Fighters
    Public Interface IFighterSystem
        ReadOnly Property BPV As UInt16
        ReadOnly Property Name As String
        ReadOnly Property Mass As Double
        ReadOnly Property Type As String
        Function GetInfo() As DataTable
    End Interface
End Namespace
