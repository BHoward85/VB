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