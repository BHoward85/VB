Namespace Fighters
    Public Class FighterType
        Private typeName As String
        Private stressAlow As UInt16

        Public Sub New()
            typeName = "Null"
            stressAlow = 0
        End Sub

        Public Sub New(ByRef name As String, ByVal alow As UInt16)
            typeName = name
            stressAlow = alow
        End Sub

        Public Property Name As String
            Get
                Return typeName
            End Get
            Set(value As String)
                If value <> String.Empty Then
                    typeName = value
                Else
                    MessageBox.Show("Missing type")
                End If
            End Set
        End Property

        Public Property Alow As UInt16
            Get
                Return stressAlow
            End Get
            Set(value As UInt16)
                If value > 0 Then
                    stressAlow = value
                Else
                    MessageBox.Show("Alow input Error")
                End If
            End Set
        End Property

        Public Overrides Function ToString() As String
            Dim str As String

            str = " "
            str += "Fighter Type: " + Name
            str += "Stress Alow: " + Alow
            str += "\n"

            ToString = str
        End Function
    End Class
End Namespace