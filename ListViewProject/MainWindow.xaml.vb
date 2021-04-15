Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        hebrewAlphabet.SelectedIndex += 1
        If hebrewAlphabet.SelectedIndex = hebrewAlphabet.Items.Count - 1 Then hebrewAlphabet.SelectedIndex = 0


    End Sub
End Class
