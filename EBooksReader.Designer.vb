<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EBooksReader
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
        Me.RTE1 = New System.Windows.Forms.RichTextBox
        Me.btnEbook = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'RTE1
        '
        Me.RTE1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RTE1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTE1.Location = New System.Drawing.Point(5, 9)
        Me.RTE1.Name = "RTE1"
        Me.RTE1.Size = New System.Drawing.Size(975, 733)
        Me.RTE1.TabIndex = 272
        Me.RTE1.Text = ""
        Me.RTE1.Visible = False
        '
        'btnEbook
        '
        Me.btnEbook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEbook.Location = New System.Drawing.Point(875, 746)
        Me.btnEbook.Name = "btnEbook"
        Me.btnEbook.Size = New System.Drawing.Size(105, 31)
        Me.btnEbook.TabIndex = 273
        Me.btnEbook.Text = "Close EBook"
        Me.btnEbook.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button9.Location = New System.Drawing.Point(740, 749)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(32, 23)
        Me.Button9.TabIndex = 283
        Me.Button9.Text = "20"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button8.Location = New System.Drawing.Point(699, 749)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(32, 23)
        Me.Button8.TabIndex = 282
        Me.Button8.Text = "18"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button7.Location = New System.Drawing.Point(658, 750)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 23)
        Me.Button7.TabIndex = 281
        Me.Button7.Text = "16"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button6.Location = New System.Drawing.Point(617, 749)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 23)
        Me.Button6.TabIndex = 280
        Me.Button6.Text = "14"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button5.Location = New System.Drawing.Point(576, 749)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 279
        Me.Button5.Text = "12"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(8, 752)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(432, 20)
        Me.txtSearch.TabIndex = 278
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(455, 750)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 23)
        Me.btnSearch.TabIndex = 277
        Me.btnSearch.Text = "Search"
        '
        'EBooksReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 781)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEbook)
        Me.Controls.Add(Me.RTE1)
        Me.Name = "EBooksReader"
        Me.Text = "EBooksReader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RTE1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnEbook As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
