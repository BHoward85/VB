Imports System.Collections.Generic

Module Tester
    Public Class Test
        Public Shared Sub Main()
            Dim dc As Fighters.DamageClass = New Fighters.DamageClass(20, "H"c, "N"c)

            dc += "G"c

            Console.WriteLine("Weapon {0}", dc)
            Console.WriteLine("Rules {0}", dc.GetAllRules)
            Console.WriteLine("Type {0}", dc.WeaponType)
            Console.WriteLine("Max Damage = {0}", dc.Value)
        End Sub
    End Class
End Module

Namespace Fighters
    Public Class DamageClass
        Private classValue As UInt16
        Private classType As Char
        Private classRules As List(Of Char)

        Public Sub New()
            classValue = 0
            classType = "!"c
            classRules = New List(Of Char)
        End Sub

        Public Sub New(ByVal value As UInt16, ByVal type As Char, ByVal ParamArray args() As Char)
            classValue = value
            classType = type
            classRules = New List(Of Char)
            For Each c In args
                Rules.Add(c)
            Next
        End Sub

        Public ReadOnly Property Value As UInt16
            Get
                Value = classValue
            End Get
        End Property

        Public ReadOnly Property WeaponType As Char
            Get
                WeaponType = classType
            End Get
        End Property
        Public ReadOnly Property Rules As List(Of Char)
            Get
                Rules = classRules
            End Get
        End Property

        Public Function GetRule(ByVal index As UInt16) As Char
            If index >= 0 And index < classRules.Count Then
                GetRule = classRules.Item(index)
            End If
            Return "-"c
        End Function

        Public Sub SetRule(ByVal rule As Char)
            If rule <> "\0" Then
                classRules.Add(rule)
            End If
        End Sub

        Public Function GetAllRules() As String
            Dim s As String = ""

            For Each c In classRules
                s += c
            Next

            Return s
        End Function

        Public Shared Operator +(ByVal base As DamageClass, ByVal rule As Char) As DamageClass
            base.SetRule(rule)
            Return base
        End Operator

        Public Overrides Function ToString() As String
            Dim s As String = ""

            s = String.Format("Class {0}{1}{2}", classValue, classType, GetAllRules())

            Return s
        End Function
    End Class
End Namespace