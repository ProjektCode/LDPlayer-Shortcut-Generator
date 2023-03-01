Public Class ProjektCode_Label
	Inherits Label

	Private mGrowing As Boolean
	Public Sub New()
		Me.AutoSize = False
	End Sub
	Private Sub ResizeLabel()
		If mGrowing Then
			Return
		End If
		Try
			mGrowing = True
			Dim width As Integer = If(Me.Parent Is Nothing, Me.Width, Me.Parent.Width)

			Dim sz As New Size(Me.Width, Int32.MaxValue)
			sz = TextRenderer.MeasureText(Me.Text, Me.Font, sz, TextFormatFlags.WordBreak)
			Me.Height = sz.Height + Padding.Bottom + Padding.Top
		Finally
			mGrowing = False
		End Try
	End Sub
	Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
		MyBase.OnTextChanged(e)
		ResizeLabel()
	End Sub
	Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
		MyBase.OnFontChanged(e)
		ResizeLabel()
	End Sub
	Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
		MyBase.OnSizeChanged(e)
		ResizeLabel()
	End Sub
End Class

