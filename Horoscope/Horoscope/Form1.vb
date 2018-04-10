Public Class frmMain
    Dim Image As Image


    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim day As Integer
        Dim year As Integer
        year = Val(cmbYear.Text)
        day = Val(cmbDay.Text)
        If (cmbDay.Text = "Ден" Or cmbMonth.Text = "Месец" Or cmbYear.Text = "Година") Or (Not (year Mod 4 = 0 And year Mod 100 <> 0) And cmbMonth.Text = "Февруари" And day > 28) Or (year Mod 4 = 0 And year Mod 100 <> 0 And cmbMonth.Text = "Февруари" And day > 29) Or (day > 30 And (cmbMonth.Text = "Април" Or cmbMonth.Text = "Юни" Or cmbMonth.Text = "Септември" Or cmbMonth.Text = "Ноември")) Then
            MsgBox("Моля въведете коректно рождената си дата!", vbOKOnly + vbExclamation, "Грешка!")
        Else

            Me.BackgroundImage = Nothing
            lbl.Visible = True
            lblZodiac.Visible = True
            btnHoroscope.Visible = True


            Select Case cmbMonth.Text
                Case "Януари"
                    If day < 21 Then
                        lblZodiac.Text = "Козирог"
                        Empty.Image = Capricorn.Image

                    Else
                        lblZodiac.Text = "Водолей"
                        Empty.Image = Aquarius.Image
                    End If
                Case "Февруари"
                    If day < 20 Then
                        lblZodiac.Text = "Водолей"
                        Empty.Image = Aquarius.Image

                    Else
                        lblZodiac.Text = "Риби"
                        Empty.Image = Pisces.Image
                    End If
                Case "Март"
                    If day < 21 Then
                        lblZodiac.Text = "Риби"
                        Empty.Image = Pisces.Image

                    Else
                        lblZodiac.Text = "Овен"
                        Empty.Image = Aries.Image
                    End If
                Case "Април"
                    If day < 21 Then
                        lblZodiac.Text = "Овен"
                        Empty.Image = Aries.Image

                    Else
                        lblZodiac.Text = "Телец"
                        Empty.Image = Taurus.Image
                    End If
                Case "Май"
                    If day < 22 Then
                        lblZodiac.Text = "Телец"
                        Empty.Image = Taurus.Image

                    Else
                        lblZodiac.Text = "Близнаци"
                        Empty.Image = Gemini.Image

                    End If
                Case "Юни"
                    If day < 22 Then
                        lblZodiac.Text = "Близнаци"
                        Empty.Image = Gemini.Image

                    Else
                        lblZodiac.Text = "Рак"
                        Empty.Image = Cancer.Image
                    End If
                Case "Юли"
                    If day < 24 Then
                        lblZodiac.Text = "Рак"
                        Empty.Image = Cancer.Image

                    Else
                        lblZodiac.Text = "Лъв"
                        Empty.Image = Leo.Image
                    End If
                Case "Август"
                    If day < 24 Then
                        lblZodiac.Text = "Лъв"
                        Empty.Image = Leo.Image

                    Else
                        lblZodiac.Text = "Дева"
                        Empty.Image = Virgo.Image
                    End If
                Case "Септември"
                    If day < 24 Then
                        lblZodiac.Text = "Дева"
                        Empty.Image = Virgo.Image

                    Else
                        lblZodiac.Text = "Везни"
                        Empty.Image = Libra.Image
                    End If
                Case "Октомври"
                    If day < 24 Then
                        lblZodiac.Text = "Везни"
                        Empty.Image = Libra.Image

                    Else
                        lblZodiac.Text = "Скорпион"
                        Empty.Image = Scorpio.Image
                    End If
                Case "Ноември"
                    If day < 23 Then
                        lblZodiac.Text = "Скорпион"
                        Empty.Image = Scorpio.Image

                    Else
                        lblZodiac.Text = "Стрелец"
                        Empty.Image = Sagitarius.Image
                    End If
                Case "Декември"
                    If day < 22 Then
                        lblZodiac.Text = "Стрелец"
                        Empty.Image = Sagitarius.Image

                    Else
                        lblZodiac.Text = "Козирог"
                        Empty.Image = Capricorn.Image
                    End If
            End Select
            If lblZodiac.Text = "Овен" Or lblZodiac.Text = "Лъв" Or lblZodiac.Text = "Стрелец" Then
                lblZodiac.ForeColor = Color.FromArgb(128, 185, 176)
                lbl.ForeColor = Color.FromArgb(168, 211, 202)
                btnHoroscope.ForeColor = Color.FromArgb(168, 211, 202)
            ElseIf lblZodiac.Text = "Козирог" Or lblZodiac.Text = "Телец" Or lblZodiac.Text = "Дева" Then
                lblZodiac.ForeColor = Color.FromArgb(180, 213, 182)
                lbl.ForeColor = Color.FromArgb(132, 150, 136)
                btnHoroscope.ForeColor = Color.FromArgb(132, 150, 136)
            ElseIf lblZodiac.Text = "Везни" Or lblZodiac.Text = "Водолей" Or lblZodiac.Text = "Близнаци" Then
                lblZodiac.ForeColor = Color.FromArgb(216, 121, 77)
                lbl.ForeColor = Color.FromArgb(228, 180, 160)
                btnHoroscope.ForeColor = Color.FromArgb(228, 180, 160)
            ElseIf lblZodiac.Text = "Рак" Or lblZodiac.Text = "Скорпион" Or lblZodiac.Text = "Риби" Then
                lblZodiac.ForeColor = Color.FromArgb(214, 112, 136)
                lbl.ForeColor = Color.FromArgb(168, 70, 108)
                btnHoroscope.ForeColor = Color.FromArgb(168, 70, 108)
            End If
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Image = BackgroundImage

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Наистина ли искате да напуснете приложението?", vbYesNo + vbQuestion, "Напускане на приложението") = vbYes Then
            Me.Close()

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbDay.Text = "Ден"
        cmbMonth.Text = "Месец"
        cmbYear.Text = "Година"
        lbl.Visible = False
        lblZodiac.Visible = False
        btnHoroscope.Visible = False
        Empty.Image = Nothing
        Me.BackgroundImage = Image


    End Sub

    Private Sub cmbDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDay.MouseEnter
        lblDay.Visible = True

    End Sub

    Private Sub cmbDay_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbDay.MouseLeave
        lblDay.Visible = False

    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.MouseEnter
        lblMonth.Visible = True


    End Sub

    Private Sub cmbMonth_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbMonth.MouseLeave
        lblMonth.Visible = False


    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.MouseEnter
        lblYear.Visible = True


    End Sub

    Private Sub cmbYear_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbYear.MouseLeave
        lblYear.Visible = False


    End Sub

    Private Sub btnHoroscope_Click(sender As Object, e As EventArgs) Handles btnHoroscope.Click
        Me.Hide()
        Select Case lblZodiac.Text
            Case "Овен"
                frmAries.Show()

            Case "Телец"
                frmTaurus.Show()

            Case "Близнаци"
                frmGemini.Show()

            Case "Везни"
                frmLibra.Show()

            Case "Козирог"
                frmCapricorn.Show()

            Case "Риби"
                frmPisces.Show()

            Case "Дева"
                frmVirgo.Show()

            Case "Скорпион"
                frmScorpio.Show()

            Case "Стрелец"
                frmSagittarius.Show()

            Case "Рак"
                frmCancer.Show()

            Case "Лъв"
                frmLeo.Show()

            Case "Водолей"
                frmAquarius.Show()

        End Select
    End Sub

    Private Sub cmbDay_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDay.SelectedIndexChanged
        lblDay.Visible = False

    End Sub

    Private Sub cmbMonth_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        lblMonth.Visible = False

    End Sub

    Private Sub cmbYear_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        lblYear.Visible = False

    End Sub
End Class
