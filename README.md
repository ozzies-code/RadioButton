# Project Title: Radio-Button
 
Este proyecto esta basado en una aplicacion que aplica descuentos 
dependiendo de la opcion seleccionada.


# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que 
 presenta una serie de opciones a traves de unos Radiobutton para
 obtener un determinado resultado sobre el total de la compra y el
 descuento aplicado a una compra dependiendo de la opcion 
 seleccionada. 
 
 # Actualizacion: 23/01/2025
 # Hora: 20:10

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

## Autores

- [@ozzies-code](https://www.github.com/ozzies-code)

## Contribuciones

¡Las contribuciones son siempre bienvenidas!

Consulta `contributing.md` para conocer cómo comenzar.

Por favor, respeta el `código de conducta` de este proyecto.

## Despliegue

Para implementar este proyecto, descargue los archivos del proyecto
del repositorio y el código del proyecto que se encuentra
en el archivo README.md

## 🚀 Acerca de Mi
Soy un apasionado desarrollador fullstack de Venezuela 🇻🇪 y Países Bajos 🇳🇱


🔭 Actualmente estoy trabajando en .NET Framework

🔭 Actualmente estoy trabajando en desarrollo web

🔭 Actualmente estoy trabajando en proyectos de .Console

🔭 Actualmente estoy trabajando en bases de datos .SQL

🌱 Actualmente estoy aprendiendo sobre frameworks, cursos, tutoriales y libros electrónicos

💬 Pregúntame sobre desarrollo de software

📫 Cómo contactarme oswaldojmp.nl@proton.me

👨‍💻 Todos mis proyectos están disponibles en https://developerandtechnologyozziescode.blogspot.com/ (mi sitio web)

📝 Escribo artículos regularmente en Medium.com/Ozzies.Code

    ## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)]( https://developerandtechnologyozziescode.blogspot.com)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](www.linkedin.com/in/oswaldo-jesús-marín-pagés-ab4499a4)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/ozzies_code)

## Lecciones Aprendidas

- Manejo del Radiobutton
- eventos del Radiobutton
- logica de programacion

## image of the Project

![imagen](https://github.com/user-attachments/assets/d906f5d3-5b68-4518-ae04-ac8dedcce67a)

## Soporte

Para soporte, email oswaldojmp.nl@proton.me

## Pila de tecnología

**Plataforma:** Visual studio 2022

**Lenguaje:** Visual Basic.NET

Codigo del Proyecto:

Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        'Declaración de variables
        'Seleccion del descuento a aplicar dependiendo de la opción seleccionada

        Dim totalCompra As Double = Val(txtTotalCompra.Text)
        Dim totalCompraDescuento As Double = 0

        If rbDescuentoCinco.Checked = True Then
            totalCompraDescuento = totalCompra - (totalCompra * 0.05)
        End If

        If rbDescuentoDiez.Checked = True Then
            totalCompraDescuento = totalCompra - (totalCompra * 0.1)
        End If

        If rbDescuentoQuince.Checked = True Then
            totalCompraDescuento = totalCompra - (totalCompra * 0.15)
        End If

        txtTotalCompraDescuento.Text = totalCompraDescuento.ToString

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicialización de los controles en False
        rbDescuentoCinco.Enabled = False
        rbDescuentoDiez.Enabled = False
        rbDescuentoQuince.Enabled = False
    End Sub

    Private Sub txtTotalCompra_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCompra.TextChanged
        'Habilitar los controles para seleccionar el descuento
        rbDescuentoCinco.Enabled = True
        rbDescuentoDiez.Enabled = True
        rbDescuentoQuince.Enabled = True
    End Sub

End Class
