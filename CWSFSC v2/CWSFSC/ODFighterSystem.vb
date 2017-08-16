'Out Dated, moving to many different system that impalments IFighterSystem

Public Class ODFighterSystem

    Private systemName As String
    Private systemMass As Double
    Private systemBPV As UInt16
    Private systemType As String
    Private systemVal As UInt16

    Public Sub New()
        systemName = "Nil"
        systemMass = 0
        systemBPV = 0
        systemType = "NilType"
        systemVal = 0
    End Sub

    Public Sub New(ByVal mass As Double, ByRef name As String, ByRef type As String, ByVal bpv As UInt16, ByVal val As UInt16)
        systemName = name
        systemMass = mass
        systemType = type
        systemBPV = bpv
        systemVal = val
    End Sub

    Public Property BPV As UInt16
        Get
            Return systemBPV
        End Get
        Set(value As UInt16)
            If value > 0 Then
                systemBPV = value
            Else
                MessageBox.Show("Needs BPV of non-zero")
            End If
        End Set
    End Property

    Public Property Value As UInt16
        Get
            Return systemVal
        End Get
        Set(value As UInt16)
            If value > 0 Then
                systemVal = value
            Else
                MessageBox.Show("Value need more than 0")
            End If
        End Set
    End Property

    Public Property Name As String
        Get
            Return systemName
        End Get
        Set(value As String)
            If value <> String.Empty Then
                systemName = value
            Else
                MessageBox.Show("Missing name")
            End If
        End Set
    End Property

    Public Property Mass As Double
        Get
            Return systemMass
        End Get
        Set(value As Double)
            If value > 0 Then
                systemMass = value
            Else
                MessageBox.Show("Enter in a non-neg mass")
            End If
        End Set
    End Property

    Public Property Type As String
        Get
            Return systemType
        End Get
        Set(value As String)
            If value <> String.Empty Then
                systemType = value
            Else
                MessageBox.Show("missing type")
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        ToString = "Name: " + Name + ", Type: " + Type + ", Mass: " + Mass + ", BPV: " + systemBPV + ", Val: " + systemVal
    End Function
End Class
