<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.btnHoroscope = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblZodiac = New System.Windows.Forms.Label()
        Me.Gemini = New System.Windows.Forms.PictureBox()
        Me.Aquarius = New System.Windows.Forms.PictureBox()
        Me.Aries = New System.Windows.Forms.PictureBox()
        Me.Cancer = New System.Windows.Forms.PictureBox()
        Me.Capricorn = New System.Windows.Forms.PictureBox()
        Me.Leo = New System.Windows.Forms.PictureBox()
        Me.Libra = New System.Windows.Forms.PictureBox()
        Me.Pisces = New System.Windows.Forms.PictureBox()
        Me.Sagitarius = New System.Windows.Forms.PictureBox()
        Me.Scorpio = New System.Windows.Forms.PictureBox()
        Me.Taurus = New System.Windows.Forms.PictureBox()
        Me.Virgo = New System.Windows.Forms.PictureBox()
        Me.Empty = New System.Windows.Forms.PictureBox()
        CType(Me.Gemini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aquarius, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cancer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Capricorn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Libra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pisces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sagitarius, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scorpio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taurus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Virgo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(38, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(528, 57)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ЗОДИЯ и ХОРОСКОП"
        '
        'cmbDay
        '
        Me.cmbDay.DropDownHeight = 117
        Me.cmbDay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.IntegralHeight = False
        Me.cmbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDay.Location = New System.Drawing.Point(148, 138)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(62, 29)
        Me.cmbDay.TabIndex = 1
        Me.cmbDay.Text = "Ден"
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownHeight = 117
        Me.cmbMonth.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.IntegralHeight = False
        Me.cmbMonth.Items.AddRange(New Object() {"Януари", "Февруари", "Март", "Април", "Май", "Юни", "Юли", "Август", "Септември", "Октомври", "Ноември", "Декември"})
        Me.cmbMonth.Location = New System.Drawing.Point(289, 138)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(116, 29)
        Me.cmbMonth.TabIndex = 2
        Me.cmbMonth.Text = "Месец"
        '
        'cmbYear
        '
        Me.cmbYear.DropDownHeight = 117
        Me.cmbYear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.IntegralHeight = False
        Me.cmbYear.Items.AddRange(New Object() {"1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015"})
        Me.cmbYear.Location = New System.Drawing.Point(443, 138)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(82, 29)
        Me.cmbYear.TabIndex = 3
        Me.cmbYear.Text = "Година"
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(12, 649)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 41)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Изчисти"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(493, 649)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 41)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Изход"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.Location = New System.Drawing.Point(248, 636)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(111, 54)
        Me.btnCheck.TabIndex = 6
        Me.btnCheck.Text = "Провери зодия"
        Me.btnCheck.UseCompatibleTextRendering = True
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDay.Location = New System.Drawing.Point(75, 109)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(209, 18)
        Me.lblDay.TabIndex = 7
        Me.lblDay.Text = "Въведете ден на раждане!"
        Me.lblDay.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblMonth.Location = New System.Drawing.Point(245, 109)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(233, 18)
        Me.lblMonth.TabIndex = 8
        Me.lblMonth.Text = "Въведете месец на раждане!"
        Me.lblMonth.Visible = False
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblYear.Location = New System.Drawing.Point(360, 109)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(233, 18)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Въведете година на раждане!"
        Me.lblYear.Visible = False
        '
        'btnHoroscope
        '
        Me.btnHoroscope.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnHoroscope.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHoroscope.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnHoroscope.ForeColor = System.Drawing.Color.White
        Me.btnHoroscope.Location = New System.Drawing.Point(243, 474)
        Me.btnHoroscope.Name = "btnHoroscope"
        Me.btnHoroscope.Size = New System.Drawing.Size(125, 54)
        Me.btnHoroscope.TabIndex = 10
        Me.btnHoroscope.Text = "Провери хороскоп"
        Me.btnHoroscope.UseCompatibleTextRendering = True
        Me.btnHoroscope.UseVisualStyleBackColor = True
        Me.btnHoroscope.Visible = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(214, 247)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(176, 24)
        Me.lbl.TabIndex = 11
        Me.lbl.Text = "Вашата зодия е"
        Me.lbl.Visible = False
        '
        'lblZodiac
        '
        Me.lblZodiac.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblZodiac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.lblZodiac.Location = New System.Drawing.Point(197, 409)
        Me.lblZodiac.Name = "lblZodiac"
        Me.lblZodiac.Size = New System.Drawing.Size(211, 43)
        Me.lblZodiac.TabIndex = 12
        Me.lblZodiac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gemini
        '
        Me.Gemini.Image = Global.Horoscope.My.Resources.Resources.Gemini
        Me.Gemini.Location = New System.Drawing.Point(243, 297)
        Me.Gemini.Name = "Gemini"
        Me.Gemini.Size = New System.Drawing.Size(118, 109)
        Me.Gemini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Gemini.TabIndex = 13
        Me.Gemini.TabStop = False
        '
        'Aquarius
        '
        Me.Aquarius.Image = Global.Horoscope.My.Resources.Resources.Aquarius
        Me.Aquarius.Location = New System.Drawing.Point(243, 297)
        Me.Aquarius.Name = "Aquarius"
        Me.Aquarius.Size = New System.Drawing.Size(118, 109)
        Me.Aquarius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Aquarius.TabIndex = 14
        Me.Aquarius.TabStop = False
        '
        'Aries
        '
        Me.Aries.Image = Global.Horoscope.My.Resources.Resources.Aries
        Me.Aries.Location = New System.Drawing.Point(243, 297)
        Me.Aries.Name = "Aries"
        Me.Aries.Size = New System.Drawing.Size(118, 109)
        Me.Aries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Aries.TabIndex = 15
        Me.Aries.TabStop = False
        '
        'Cancer
        '
        Me.Cancer.Image = Global.Horoscope.My.Resources.Resources.Cancer
        Me.Cancer.Location = New System.Drawing.Point(243, 297)
        Me.Cancer.Name = "Cancer"
        Me.Cancer.Size = New System.Drawing.Size(118, 109)
        Me.Cancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Cancer.TabIndex = 16
        Me.Cancer.TabStop = False
        '
        'Capricorn
        '
        Me.Capricorn.Image = Global.Horoscope.My.Resources.Resources.Capricorn
        Me.Capricorn.Location = New System.Drawing.Point(243, 297)
        Me.Capricorn.Name = "Capricorn"
        Me.Capricorn.Size = New System.Drawing.Size(118, 109)
        Me.Capricorn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Capricorn.TabIndex = 17
        Me.Capricorn.TabStop = False
        '
        'Leo
        '
        Me.Leo.Image = Global.Horoscope.My.Resources.Resources.Leo
        Me.Leo.Location = New System.Drawing.Point(243, 297)
        Me.Leo.Name = "Leo"
        Me.Leo.Size = New System.Drawing.Size(118, 109)
        Me.Leo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Leo.TabIndex = 18
        Me.Leo.TabStop = False
        '
        'Libra
        '
        Me.Libra.Image = Global.Horoscope.My.Resources.Resources.Libra
        Me.Libra.Location = New System.Drawing.Point(243, 297)
        Me.Libra.Name = "Libra"
        Me.Libra.Size = New System.Drawing.Size(118, 109)
        Me.Libra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Libra.TabIndex = 19
        Me.Libra.TabStop = False
        '
        'Pisces
        '
        Me.Pisces.Image = Global.Horoscope.My.Resources.Resources.Pisces
        Me.Pisces.Location = New System.Drawing.Point(243, 297)
        Me.Pisces.Name = "Pisces"
        Me.Pisces.Size = New System.Drawing.Size(118, 109)
        Me.Pisces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Pisces.TabIndex = 20
        Me.Pisces.TabStop = False
        '
        'Sagitarius
        '
        Me.Sagitarius.Image = Global.Horoscope.My.Resources.Resources.Sagitarius
        Me.Sagitarius.Location = New System.Drawing.Point(243, 297)
        Me.Sagitarius.Name = "Sagitarius"
        Me.Sagitarius.Size = New System.Drawing.Size(118, 109)
        Me.Sagitarius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Sagitarius.TabIndex = 21
        Me.Sagitarius.TabStop = False
        '
        'Scorpio
        '
        Me.Scorpio.Image = Global.Horoscope.My.Resources.Resources.Scorpio
        Me.Scorpio.Location = New System.Drawing.Point(243, 297)
        Me.Scorpio.Name = "Scorpio"
        Me.Scorpio.Size = New System.Drawing.Size(118, 109)
        Me.Scorpio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Scorpio.TabIndex = 22
        Me.Scorpio.TabStop = False
        '
        'Taurus
        '
        Me.Taurus.Image = Global.Horoscope.My.Resources.Resources.Taurus
        Me.Taurus.Location = New System.Drawing.Point(243, 297)
        Me.Taurus.Name = "Taurus"
        Me.Taurus.Size = New System.Drawing.Size(118, 109)
        Me.Taurus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Taurus.TabIndex = 23
        Me.Taurus.TabStop = False
        '
        'Virgo
        '
        Me.Virgo.Image = Global.Horoscope.My.Resources.Resources.Virgo
        Me.Virgo.Location = New System.Drawing.Point(243, 297)
        Me.Virgo.Name = "Virgo"
        Me.Virgo.Size = New System.Drawing.Size(118, 109)
        Me.Virgo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Virgo.TabIndex = 24
        Me.Virgo.TabStop = False
        '
        'Empty
        '
        Me.Empty.BackColor = System.Drawing.Color.Transparent
        Me.Empty.Location = New System.Drawing.Point(243, 297)
        Me.Empty.Name = "Empty"
        Me.Empty.Size = New System.Drawing.Size(118, 109)
        Me.Empty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Empty.TabIndex = 25
        Me.Empty.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BackgroundImage = Global.Horoscope.My.Resources.Resources.Zodiac_Signs_500
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(605, 701)
        Me.Controls.Add(Me.Empty)
        Me.Controls.Add(Me.Virgo)
        Me.Controls.Add(Me.Taurus)
        Me.Controls.Add(Me.Scorpio)
        Me.Controls.Add(Me.Sagitarius)
        Me.Controls.Add(Me.Pisces)
        Me.Controls.Add(Me.Libra)
        Me.Controls.Add(Me.Leo)
        Me.Controls.Add(Me.Capricorn)
        Me.Controls.Add(Me.Cancer)
        Me.Controls.Add(Me.Aries)
        Me.Controls.Add(Me.Aquarius)
        Me.Controls.Add(Me.Gemini)
        Me.Controls.Add(Me.lblZodiac)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnHoroscope)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Хороскоп"
        CType(Me.Gemini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aquarius, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cancer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Capricorn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Libra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pisces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sagitarius, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scorpio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taurus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Virgo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents btnHoroscope As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents lblZodiac As System.Windows.Forms.Label
    Friend WithEvents Gemini As System.Windows.Forms.PictureBox
    Friend WithEvents Aquarius As System.Windows.Forms.PictureBox
    Friend WithEvents Aries As System.Windows.Forms.PictureBox
    Friend WithEvents Cancer As System.Windows.Forms.PictureBox
    Friend WithEvents Capricorn As System.Windows.Forms.PictureBox
    Friend WithEvents Leo As System.Windows.Forms.PictureBox
    Friend WithEvents Libra As System.Windows.Forms.PictureBox
    Friend WithEvents Pisces As System.Windows.Forms.PictureBox
    Friend WithEvents Sagitarius As System.Windows.Forms.PictureBox
    Friend WithEvents Scorpio As System.Windows.Forms.PictureBox
    Friend WithEvents Taurus As System.Windows.Forms.PictureBox
    Friend WithEvents Virgo As System.Windows.Forms.PictureBox
    Friend WithEvents Empty As System.Windows.Forms.PictureBox

End Class
