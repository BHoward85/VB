VERSION 5.00
Begin VB.Form DamageCal 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Damage Calulator"
   ClientHeight    =   4335
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   4095
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4790.055
   ScaleMode       =   0  'User
   ScaleWidth      =   4305.994
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame7 
      Caption         =   "Hit"
      Height          =   615
      Left            =   1440
      TabIndex        =   22
      Top             =   2160
      Width           =   1215
      Begin VB.Label Hit 
         Alignment       =   2  'Center
         Caption         =   "0"
         Height          =   255
         Left            =   120
         TabIndex        =   23
         Top             =   240
         Width           =   975
      End
   End
   Begin VB.CommandButton Exit 
      Caption         =   "Exit"
      Height          =   375
      Left            =   120
      TabIndex        =   21
      Top             =   3840
      Width           =   1215
   End
   Begin VB.CommandButton Calulate 
      Caption         =   "Run"
      Height          =   375
      Left            =   2760
      TabIndex        =   20
      Top             =   3840
      Width           =   1215
   End
   Begin VB.CommandButton FormulaSet 
      Caption         =   "Formula Set"
      Height          =   375
      Left            =   2760
      TabIndex        =   19
      Top             =   3360
      Width           =   1215
   End
   Begin VB.Frame Frame6 
      Caption         =   "HP after"
      Height          =   615
      Left            =   2760
      TabIndex        =   16
      Top             =   2160
      Width           =   1215
      Begin VB.Label HPleft 
         Alignment       =   2  'Center
         Caption         =   "0"
         Height          =   255
         Left            =   120
         TabIndex        =   18
         Top             =   240
         Width           =   975
      End
   End
   Begin VB.Frame Frame5 
      Caption         =   "HP before"
      Height          =   615
      Left            =   120
      TabIndex        =   15
      Top             =   2160
      Width           =   1215
      Begin VB.Label HPtotal 
         Alignment       =   2  'Center
         Caption         =   "0"
         Height          =   255
         Left            =   120
         TabIndex        =   17
         Top             =   240
         Width           =   975
      End
   End
   Begin VB.Frame Frame4 
      Caption         =   "Formula"
      Height          =   735
      Left            =   120
      TabIndex        =   13
      Top             =   600
      Width           =   3855
      Begin VB.Label FormulaField 
         Alignment       =   2  'Center
         Caption         =   "(Damage * (Modifiers / 100)) - (Defence * 1.25) = hit"
         Height          =   375
         Left            =   120
         TabIndex        =   14
         Top             =   240
         Width           =   3615
      End
   End
   Begin VB.TextBox InputField 
      Alignment       =   2  'Center
      Height          =   375
      Left            =   120
      TabIndex        =   12
      Top             =   120
      Width           =   3855
   End
   Begin VB.Frame Frame3 
      Caption         =   "Defence"
      Height          =   615
      Left            =   2760
      TabIndex        =   8
      Top             =   1440
      Width           =   1215
      Begin VB.Label DefenceField 
         Alignment       =   2  'Center
         Caption         =   "0"
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   240
         Width           =   975
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Modifier"
      Height          =   615
      Left            =   1440
      TabIndex        =   7
      Top             =   1440
      Width           =   1215
      Begin VB.Label ModifierField 
         Alignment       =   2  'Center
         Caption         =   "0"
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   240
         Width           =   975
      End
   End
   Begin VB.CommandButton ResetOthers 
      Caption         =   "Formula Reset"
      Height          =   375
      Left            =   2760
      TabIndex        =   5
      Top             =   2880
      Width           =   1215
   End
   Begin VB.CommandButton HPreset 
      Caption         =   "HP Reset"
      Height          =   375
      Left            =   120
      TabIndex        =   4
      Top             =   3360
      Width           =   1215
   End
   Begin VB.CommandButton ToHP 
      Caption         =   "HP Set"
      Height          =   375
      Left            =   120
      TabIndex        =   3
      Top             =   2880
      Width           =   1215
   End
   Begin VB.CommandButton ModifiersIn 
      Caption         =   "Modifier"
      Height          =   375
      Left            =   1440
      TabIndex        =   2
      Top             =   3360
      Width           =   1215
   End
   Begin VB.CommandButton DefenceIn 
      Caption         =   "Defence"
      Height          =   375
      Left            =   1440
      TabIndex        =   1
      Top             =   3840
      Width           =   1215
   End
   Begin VB.CommandButton DamageIn 
      Caption         =   "Damage"
      Height          =   375
      Left            =   1440
      TabIndex        =   0
      Top             =   2880
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Caption         =   "Damage"
      Height          =   615
      Left            =   120
      TabIndex        =   6
      Top             =   1440
      Width           =   1215
      Begin VB.Label DamageField 
         Alignment       =   2  'Center
         Caption         =   "0"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   240
         Width           =   975
      End
   End
End
Attribute VB_Name = "DamageCal"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Damage As Double
Public Modifiers As Double
Public Defence As Double
Public HP As Double

Private Sub Calulate_Click()
    TotalDamage = ((Damage * (Modifiers / 100)) - (Defence * 1.25))
    Total = (HP - ((Damage * (Modifiers / 100)) - (Defence * 1.25)))
    'Testing if Damage is more then 0
    If TotalDamage > 0 Then
        If Total > 0 Then
            Hit.Caption = HP - Total
            HPleft.Caption = Total
        Else
            Hit.Caption = HP - Total
            HPleft.Caption = 0
        End If
    Else 'The damage is less then 0 there for no lost in HP
        Hit.Caption = 0
        HPleft.Caption = HP
    End If
End Sub

Private Sub DamageIn_Click()
    Damage = InputField.Text
    DamageField.Caption = Damage
End Sub

Private Sub DefenceIn_Click()
    Defence = InputField.Text
    DefenceField.Caption = Defence
End Sub

Private Sub FormulaSet_Click()
    'Finding out the TotalHit
    TotalHit = ((Damage * (Modifiers / 100)) - (Defence * 1.25))
    'Casting Doubles to Strings
    DamageString = CStr(Damage)
    ModifiersString = CStr(Modifiers)
    DefenceString = CStr(Defence)
    TotalHitString = CStr(TotalHit)
    'Printing the Formula
    FormulaString = "(" + DamageString + " * (" + ModifiersString + "/ 100)) - (" + DefenceString + " * 1.25)"
    FormulaField.Caption = FormulaString + " = " + TotalHitString
End Sub

Private Sub HPreset_Click()
    HP = 0
    HPtotal.Caption = 0
    HPleft.Caption = 0
    Hit.Caption = 0
End Sub

Private Sub ModifiersIn_Click()
    Modifiers = InputField.Text
    ModifierField.Caption = Modifiers
End Sub

Private Sub ResetOthers_Click()
    'FormulaField Reset
    FormulaField.Caption = "(Damage * (Modifiers / 100)) - (Defence * 1.25) = Hit"
    'Info Reset
    Damage = 0
    Modifiers = 0
    Defence = 0
    'Field Reset
    DamageField.Caption = 0
    ModifierField.Caption = 0
    DefenceField.Caption = 0
    Hit.Caption = 0
End Sub

Private Sub ToHP_Click()
    HP = InputField.Text
    HPtotal.Caption = HP
End Sub

Private Sub Exit_Click()
    End
End Sub

