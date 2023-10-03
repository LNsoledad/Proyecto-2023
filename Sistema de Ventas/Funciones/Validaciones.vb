Imports System.Text.RegularExpressions

Module Validacion


    'PARA VALIDAR INGRESO DE NUMEROS EN TEXT BOX
    Public Sub validarSoloNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        '// e captura el caracter que el usuario esta tecleando
        '// si el caracter presionado es numero
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            ''//Habilitamos la escritura
        ElseIf Char.IsControl(e.KeyChar) Then '//SIRVE PARA HABILITAR LA TECLA BORRAR EN CASO QUE SE DESEE CORREGIR
            e.Handled = False
        Else
            e.Handled = True

        End If
        If e.Handled = True Then
            MsgBox("Ingrese solo números", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub

    'PARA VALIDAR SOLO LETRAS
    Public Sub validarSoloLetras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        ElseIf Char.IsControl(e.KeyChar) Then 'SIRVE PARA HABILITAR LA TECLA BORRAR EN CASO QUE SE DESEE CORREGIR
            e.Handled = False
        Else
            e.Handled = False

        End If
        If e.Handled = True Then
            MsgBox("INGRESE SOLO LETRAS", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    'PARA VALIDAR INGRESO DE NUMEROS Y LETRAS DIRECCION
    Public Sub validarNumerosYLetras1(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Permite apretar la tecla para borrar
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then 'permite apretar la tecla espaciadora
            e.Handled = False
        Else
            e.Handled = True
            'MsgBox("INGRESE solo numero y letras", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub


End Module