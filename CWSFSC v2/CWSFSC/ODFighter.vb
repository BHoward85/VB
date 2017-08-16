'Outdated rebuild by have different systems, engine, FCS, Radio, heatsinks, guns, missile, and other types
Imports CWSFSC.Fighters
Public Class ODFighter
    Private fighterName As String
    Private fighterType As FighterType
    Private fighterMass As UInt64
    Private sizeClass As UInt16
    Private crewSize As Byte
    Private DFR As Byte
    Private FCS As Byte
    Private chaffCount As Byte
    Private hitPoints As UInt16
    Private sensorUnits As UInt16
    Private hardPoint As Byte
    Private topSpeed As Byte
    Private fighterBPV As UInt16
    Private fighterStessPoints As Byte
    Private fighterStessClass As Char
    Private fighterSystemSet As ArrayList
    Private fighterFCS As ODFighterSystem
    Private fighterFSheild As ODFighterSystem
    Private fighterASheild As ODFighterSystem
    Private fighterTechEra As String

    Public Sub New()
        fighterName = "Nil"
        fighterType = New FighterType()
        fighterMass = 0
        sizeClass = 1
        crewSize = 0
        DFR = 0
        FCS = 0
        chaffCount = 0
        hitPoints = 0
        sensorUnits = 0
        hardPoint = 0
        topSpeed = 0
        fighterBPV = 0
        fighterStessPoints = 0
        fighterStessClass = "N"c
        fighterSystemSet = New ArrayList
        fighterFCS = New ODFighterSystem()
        fighterFSheild = New ODFighterSystem()
        fighterASheild = New ODFighterSystem()
        fighterTechEra = "-2X"
    End Sub

    Public Sub New(ByRef name As String, ByRef starFrameType As FighterType, ByRef systemSet As ArrayList, ByVal DFR As Byte, ByRef tech As String)
        Me.New()
        fighterName = name
        fighterType = starFrameType
        fighterSystemSet = systemSet
        Me.DFR = DFR
        fighterTechEra = tech
    End Sub

    Public ReadOnly Property FrontShieldValue As UInt64
        Get
            Return fighterFSheild.Value
        End Get
    End Property

    Public ReadOnly Property AftShieldValue As UInt64
        Get
            Return fighterASheild.Value
        End Get
    End Property

    Public Property Sensors As UInt16
        Get
            Return sensorUnits
        End Get
        Set(value As UInt16)
            If value > 0 Then
                sensorUnits = value
            Else
                MessageBox.Show("Sensor Value need to be more than 0")
            End If
        End Set
    End Property

    Public Property HardPoints As Byte
        Get
            Return hardPoint
        End Get
        Set(value As Byte)
            If value >= 0 Then
                hardPoint = value
            Else
                MessageBox.Show("Hardpoints needs to be a postive number")
            End If
        End Set
    End Property

    Public Property StressPoints As Byte
        Get
            Return fighterStessPoints
        End Get
        Set(value As Byte)
            If value > 0 Then
                fighterStessPoints = value
            Else
                MessageBox.Show("The stess point need to be more than 0")
            End If
        End Set
    End Property

    Public Property Size As UInt16
        Get
            Return sizeClass
        End Get
        Set(value As UInt16)
            If value > 0 Then
                sizeClass = value
            Else
                MessageBox.Show("Size must more than 0")
            End If
        End Set
    End Property

    Public Property Speed As Byte
        Get
            Return topSpeed
        End Get
        Set(value As Byte)
            If value > 0 Then
                topSpeed = value
            Else
                MessageBox.Show("Top speed needs to more than 0")
            End If
        End Set
    End Property

    Public Property Chaff As Byte
        Get
            Return chaffCount
        End Get
        Set(value As Byte)
            If value >= 0 Then
                chaffCount = value
            Else
                MessageBox.Show("Chaff count must be 0 or more")
            End If
        End Set
    End Property

    Public Property Crew As Byte
        Get
            Return crewSize
        End Get
        Set(value As Byte)
            If value > 0 Then
                crewSize = value
            Else
                MessageBox.Show("Crew size must be more than 0")
            End If
        End Set
    End Property

    Public Property HitPoint As UInt16
        Get
            Return hitPoints
        End Get
        Set(value As UInt16)
            If value > 0 Then
                hitPoints = value
            Else
                MessageBox.Show("HitPoints missing")
            End If
        End Set
    End Property


    Public Property BPV As UInt16
        Get
            Return fighterBPV
        End Get
        Set(value As UInt16)
            If value > 0 Then
                fighterBPV = value
            Else
                MessageBox.Show("BPV error")
            End If
        End Set
    End Property

    Public Property FireConSys As Byte
        Get
            Return FCS
        End Get
        Set(value As Byte)
            If value > 0 Then
                FCS = FireConSys
            Else
                MessageBox.Show("Missing FSC number")
            End If
        End Set
    End Property

    Public Property DogFightRate As Byte
        Get
            Return DFR
        End Get
        Set(value As Byte)
            If value >= 0 Then
                DFR = value
            Else
                MessageBox.Show("Missing DFR number")
            End If
        End Set
    End Property

    Public Property Name As String
        Get
            Return fighterName
        End Get
        Set(value As String)
            If value <> String.Empty Then
                fighterName = value
            Else
                MessageBox.Show("Missing Name")
            End If
        End Set
    End Property

    Public Property StarFrameType As FighterType
        Get
            Return fighterType
        End Get
        Set(value As FighterType)
            If value.Name <> vbNull Then
                fighterType = value
            Else
                MessageBox.Show("Missing Type")
            End If
        End Set
    End Property

    Public Property Mass As UInt64
        Get
            Return fighterMass
        End Get
        Set(value As UInt64)
            If value > 0 Then
                fighterMass = value
            Else
                MessageBox.Show("Mass input Error")
            End If
        End Set
    End Property

    Public Property StressClass As Char
        Get
            Return fighterStessClass
        End Get
        Set(value As Char)
            If value <> "\0" Then
                fighterStessClass = value
            Else
                MessageBox.Show("Class type missing")
            End If
        End Set
    End Property

    Public ReadOnly Property FighterSystems As ArrayList
        Get
            Return fighterSystemSet
        End Get
    End Property
    'this is get a weapon from the set
    Public Function GetFighterSystem(ByVal index) As ODFighterSystem
        If index >= 0 And index < fighterSystemSet.Count Then
            Return fighterSystemSet(index)
        End If
        Return New ODFighterSystem()
    End Function
    'to set a weapon within the set
    Public Sub SetFighterSystem(ByRef newFighterSystem As ODFighterSystem)

        If newFighterSystem.Type = "FCS" Then
            If Not HasFCS() Then
                ReplaceFCS(newFighterSystem)
            Else
                If MessageBox.Show("Do you want to replace the current FCS?", "Replace FCS", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    ReplaceFCS(newFighterSystem)
                End If
            End If
        ElseIf newFighterSystem.Type = "FShield" Or newFighterSystem.Type = "AShield" Then
            If newFighterSystem.Type = "FShield" Then
                If Not HasFShield() Then
                    ReplaceFShield(newFighterSystem)
                Else
                    If MessageBox.Show("Do you wnat ot replace the Current Front Shield?", "Replace Shield", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        ReplaceFShield(newFighterSystem)
                    End If
                End If
            ElseIf newFighterSystem.Type = "AShield" Then
                If Not HasAShield() Then
                    ReplaceAShield(newFighterSystem)
                Else
                    If MessageBox.Show("Do you wnat ot replace the Current Aft Shield?", "Replace Shield", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        ReplaceAShield(newFighterSystem)
                    End If
                End If
            End If
        Else
            fighterSystemSet.Add(newFighterSystem)
        End If
    End Sub
    'TODO: set up the rest of the function and sub for the fighter class

    Public Sub ReplaceFShield(ByRef newFighterSystem As ODFighterSystem)
        fighterFSheild = newFighterSystem
    End Sub

    Public Sub ReplaceAShield(ByRef newFighterSystem As ODFighterSystem)
        fighterASheild = newFighterSystem
    End Sub

    Public Function HasFShield() As Boolean
        If Not fighterFSheild.Name = "Nil" Then
            Return True
        End If

        Return False
    End Function
    Public Function HasAShield() As Boolean
        If Not fighterASheild.Name = "Nil" Then
            Return True
        End If

        Return False
    End Function

    Public Sub ReplaceFCS(ByRef newFighterSystem As ODFighterSystem)
        fighterFCS = newFighterSystem
    End Sub

    Public Function HasFCS() As Boolean
        If Not fighterFCS.Name = "Nil" Then
            Return True
        End If

        Return False
    End Function

    Public Sub CalMass()
        Dim total As UInt64

        For Each f As ODFighterSystem In fighterSystemSet
            total += f.Mass
        Next

        Me.Mass = total
    End Sub

    Public Sub CalBPV()
        Dim total As UInt16

        For Each f As ODFighterSystem In fighterSystemSet
            total += f.BPV
        Next

        Me.BPV = total
    End Sub

    Public Sub CalStressClass()
        Dim frameMass As Double = 0.0
        Dim massMod As Double = 0.0
        Dim stressRes As Double = 0.0

        massMod = GetMassMod()

        frameMass += fighterASheild.Mass + fighterFSheild.Mass
        frameMass += Sensors
        frameMass += Crew
        frameMass += HardPoints
        frameMass += GetWeaponsMass()
        frameMass += GetEnginesMass()

        frameMass /= massMod

        frameMass += HardPoints
        frameMass += Speed
        frameMass += DogFightRate
        frameMass += Chaff
        frameMass += fighterFCS.Mass

        stressRes = frameMass / fighterType.Alow

        GetStressClass(stressRes)
    End Sub

    Private Sub GetStressClass(ByVal stressRes As Double)
        If stressRes >= 2.0 Then ' Value - 2.0+
            StressClass = "A"
        ElseIf stressRes < 2.0 And stressRes >= 1.7 Then ' Value - 1.8
            StressClass = "B"
        ElseIf stressRes < 1.7 And stressRes >= 1.5 Then ' Value - 1.6
            StressClass = "C"
        ElseIf stressRes < 1.5 And stressRes >= 1.3 Then ' Value - 1.4
            StressClass = "D"
        ElseIf stressRes < 1.3 And stressRes >= 1.1 Then ' Value - 1.2
            StressClass = "E"
        ElseIf stressRes < 1.1 And stressRes >= 0.9375 Then ' Value - 1.0
            StressClass = "F"
        ElseIf stressRes < 0.9375 And stressRes >= 0.8125 Then ' Value - 0.825
            StressClass = "G"
        ElseIf stressRes < 0.8125 And stressRes >= 0.6875 Then ' Value - 0.75
            StressClass = "H"
        ElseIf stressRes < 0.6875 And stressRes >= 0.5625 Then ' Value - 0.625
            StressClass = "I"
        ElseIf stressRes < 0.5625 Then ' Value - 0.5-
            StressClass = "J"
        Else
            StressClass = "K"
        End If
    End Sub

    Private Function GetMassMod()
        Dim massMod As Double = 0.0

        Select Case fighterTechEra
            Case "-2X"
                massMod += 4 / Size
            Case "-1X"
                massMod += 3 / Size
            Case "0X"
                massMod += 2 / Size
            Case "1X"
                massMod += 2 / (Size + 1)
            Case "2X"
                massMod += 2 / (Size + 2)
            Case "3X"
                massMod += 2 / (Size + 3)
            Case Else
                massMod += 1
        End Select

        Return massMod
    End Function

    Private Function GetEnginesMass() As UInt64
        Dim total As UInt64 = 0

        For Each f As ODFighterSystem In fighterSystemSet
            If f.Type = "Engine" Then
                total += f.Mass
            End If
        Next

        Return total
    End Function

    Private Function GetWeaponsMass() As UInt64
        Dim total As UInt64 = 0

        For Each f As ODFighterSystem In fighterSystemSet
            If f.Type = "Weapon" Then
                total += f.Mass
            End If
        Next

        Return total
    End Function

    Public Sub SetFCSrate()
        FireConSys = fighterFCS.Value
    End Sub

    Public Sub SetSensorUnits()
        Dim total As UInt16

        total += fighterFSheild.Value + fighterASheild.Value

        Sensors = total / 2
    End Sub
    Public Overrides Function ToString() As String
        Dim str As String
        str = String.Empty

        str += "Name: " + Name + "\n"
        str += "Type: " + "\n"


        ToString = str
    End Function
End Class