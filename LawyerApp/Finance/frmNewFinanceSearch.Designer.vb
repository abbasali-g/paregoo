﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewFinanceSearch
    Inherits GlobalForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewFinanceSearch))
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.btnContactSearh = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NewFinanceSearch1 = New WFControls.VB.NewFinanceSearch()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlTitle.Controls.Add(Me.btnContactSearh)
        Me.pnlTitle.Controls.Add(Me.btnHelp)
        Me.pnlTitle.Controls.Add(Me.Label2)
        Me.pnlTitle.Location = New System.Drawing.Point(6, 1)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(547, 23)
        Me.pnlTitle.TabIndex = 6
        '
        'btnContactSearh
        '
        Me.btnContactSearh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnContactSearh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContactSearh.FlatAppearance.BorderSize = 0
        Me.btnContactSearh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnContactSearh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnContactSearh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContactSearh.Image = Global.LawyerApp.My.Resources.Resources.contact20
        Me.btnContactSearh.Location = New System.Drawing.Point(7, 1)
        Me.btnContactSearh.Name = "btnContactSearh"
        Me.btnContactSearh.Size = New System.Drawing.Size(20, 20)
        Me.btnContactSearh.TabIndex = 12
        Me.btnContactSearh.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Location = New System.Drawing.Point(6, 3)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(18, 18)
        Me.btnHelp.TabIndex = 8
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(446, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "جستحوی مالی "
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 300
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        '
        'NewFinanceSearch1
        '
        Me.NewFinanceSearch1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.NewFinanceSearch1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NewFinanceSearch1.Location = New System.Drawing.Point(6, 25)
        Me.NewFinanceSearch1.Name = "NewFinanceSearch1"
        Me.NewFinanceSearch1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NewFinanceSearch1.Size = New System.Drawing.Size(547, 654)
        Me.NewFinanceSearch1.TabIndex = 7
        '
        'frmNewFinanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 698)
        Me.Controls.Add(Me.NewFinanceSearch1)
        Me.Controls.Add(Me.pnlTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNewFinanceSearch"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnContactSearh As System.Windows.Forms.Button
    Friend WithEvents NewFinanceSearch1 As WFControls.VB.NewFinanceSearch
End Class
