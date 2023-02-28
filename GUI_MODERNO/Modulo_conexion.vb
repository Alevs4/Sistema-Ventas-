Imports MySql.Data
Imports MySql.Data.MySqlClient

Module Modulo_Conexion

    Friend conexion As New MySqlConnection ' Cargar productos a grillaProductos al iniciar el formulario
    Friend SC1 As New MySqlCommand
    Friend DA1 As New MySqlDataAdapter
    Friend DS1 As New DataSet()
    Friend DT1 As New DataTable

    Friend conexion2 As New MySqlConnection ' Agregar Producto
    Friend SC2 As New MySqlCommand
    Friend DA2 As New MySqlDataAdapter
    Friend DS2 As New DataSet()
    Friend DT2 As New DataTable

    Friend conexion3 As New MySqlConnection ' Cargar combo Marcas
    Friend SC3 As New MySqlCommand
    Friend DA3 As New MySqlDataAdapter
    Friend DS3 As New DataSet()
    Friend DT3 As New DataTable

    Friend conexion4 As New MySqlConnection ' Cargar combo Categorias
    Friend SC4 As New MySqlCommand
    Friend DA4 As New MySqlDataAdapter
    Friend DS4 As New DataSet()
    Friend DT4 As New DataTable

    Friend conexion5 As New MySqlConnection ' Obtenemos número del ultimo codigo de productos
    Friend SC5 As New MySqlCommand
    Friend DA5 As New MySqlDataAdapter
    Friend DS5 As New DataSet()
    Friend DT5 As New DataTable

    Friend conexion6 As New MySqlConnection ' Eliminamos productos
    Friend SC6 As New MySqlCommand
    Friend DA6 As New MySqlDataAdapter
    Friend DS6 As New DataSet()
    Friend DT6 As New DataTable

    Friend conexion7 As New MySqlConnection ' Añadimos Categorias
    Friend SC7 As New MySqlCommand
    Friend DA7 As New MySqlDataAdapter
    Friend DS7 As New DataSet()
    Friend DT7 As New DataTable

    Friend conexion8 As New MySqlConnection ' Consultamos por categorias
    Friend SC8 As New MySqlCommand
    Friend DA8 As New MySqlDataAdapter
    Friend DS8 As New DataSet()
    Friend DT8 As New DataTable

    Friend conexion9 As New MySqlConnection ' Consultamos Marcas
    Friend SC9 As New MySqlCommand
    Friend DA9 As New MySqlDataAdapter
    Friend DS9 As New DataSet()
    Friend DT9 As New DataTable

    Friend conexion10 As New MySqlConnection ' Añadimos Marcas
    Friend SC10 As New MySqlCommand
    Friend DA10 As New MySqlDataAdapter
    Friend DS10 As New DataSet()
    Friend DT10 As New DataTable

    Friend conexion11 As New MySqlConnection ' Buscamos por Nombre
    Friend SC11 As New MySqlCommand
    Friend DA11 As New MySqlDataAdapter
    Friend DS11 As New DataSet()
    Friend DT11 As New DataTable

    Friend conexion12 As New MySqlConnection ' Buscamos por Codigo de Producto
    Friend SC12 As New MySqlCommand
    Friend DA12 As New MySqlDataAdapter
    Friend DS12 As New DataSet()
    Friend DT12 As New DataTable

    Friend conexion13 As New MySqlConnection ' Buscamos por Codigo de Barras
    Friend SC13 As New MySqlCommand
    Friend DA13 As New MySqlDataAdapter
    Friend DS13 As New DataSet()
    Friend DT13 As New DataTable

    Friend conexion14 As New MySqlConnection ' Editar producto
    Friend SC14 As New MySqlCommand
    Friend DA14 As New MySqlDataAdapter
    Friend DS14 As New DataSet()
    Friend DT14 As New DataTable

    Friend conexion15 As New MySqlConnection ' Cargar datos producto a editar
    Friend SC15 As New MySqlCommand
    Friend DA15 As New MySqlDataAdapter
    Friend DS15 As New DataSet()
    Friend DT15 As New DataTable

    Friend conexion16 As New MySqlConnection ' Cargar grilla de ventas
    Friend SC16 As New MySqlCommand
    Friend DA16 As New MySqlDataAdapter
    Friend DS16 As New DataSet()
    Friend DT16 As New DataTable

    Friend conexion17 As New MySqlConnection ' Buscar cliente
    Friend SC17 As New MySqlCommand
    Friend DA17 As New MySqlDataAdapter
    Friend DS17 As New DataSet()
    Friend DT17 As New DataTable

    Friend conexion18 As New MySqlConnection ' Buscar producto para venta
    Friend SC18 As New MySqlCommand
    Friend DA18 As New MySqlDataAdapter
    Friend DS18 As New DataSet()
    Friend DT18 As New DataTable

    Friend conexion19 As New MySqlConnection ' Doble click DGV para cargar datos producto
    Friend SC19 As New MySqlCommand
    Friend DA19 As New MySqlDataAdapter
    Friend DS19 As New DataSet()
    Friend DT19 As New DataTable

    Friend conexion20 As New MySqlConnection ' Actualizar stock / restar
    Friend SC20 As New MySqlCommand
    Friend DA20 As New MySqlDataAdapter
    Friend DS20 As New DataSet()
    Friend DT20 As New DataTable

    Friend conexion21 As New MySqlConnection ' Grabar en tabla ventas
    Friend SC21 As New MySqlCommand
    Friend DA21 As New MySqlDataAdapter
    Friend DS21 As New DataSet()
    Friend DT21 As New DataTable

    Friend conexion22 As New MySqlConnection ' Crear numero de factura
    Friend SC22 As New MySqlCommand
    Friend DA22 As New MySqlDataAdapter
    Friend DS22 As New DataSet()
    Friend DT22 As New DataTable

    Friend conexion23 As New MySqlConnection ' Boton buscar código de barras
    Friend SC23 As New MySqlCommand
    Friend DA23 As New MySqlDataAdapter
    Friend DS23 As New DataSet()
    Friend DT23 As New DataTable

    Friend conexion24 As New MySqlConnection 'Cargar lotes a vencer
    Friend SC24 As New MySqlCommand
    Friend DA24 As New MySqlDataAdapter
    Friend DS24 As New DataSet()
    Friend DT24 As New DataTable

    Friend conexion25 As New MySqlConnection ' Ingresar Lote a vencer en caso de ser necesario
    Friend SC25 As New MySqlCommand
    Friend DA25 As New MySqlDataAdapter
    Friend DS25 As New DataSet()
    Friend DT25 As New DataTable

    Friend conexion26 As New MySqlConnection ' Cargar en formulario principal, productos a vencer
    Friend SC26 As New MySqlCommand
    Friend DA26 As New MySqlDataAdapter
    Friend DS26 As New DataSet()
    Friend DT26 As New DataTable

    Friend conexion27 As New MySqlConnection ' Ingresar el Detalle de la venta
    Friend SC27 As New MySqlCommand
    Friend DA27 As New MySqlDataAdapter
    Friend DS27 As New DataSet()
    Friend DT27 As New DataTable

    Friend conexion28 As New MySqlConnection ' Cargar detalle de venta seleccionada
    Friend SC28 As New MySqlCommand
    Friend DA28 As New MySqlDataAdapter
    Friend DS28 As New DataSet()
    Friend DT28 As New DataTable

    Friend conexion29 As New MySqlConnection ' Buscar ventas por Numero de boleta
    Friend SC29 As New MySqlCommand
    Friend DA29 As New MySqlDataAdapter
    Friend DS29 As New DataSet()
    Friend DT29 As New DataTable

    Friend conexion30 As New MySqlConnection ' Buscar ventas por Fecha
    Friend SC30 As New MySqlCommand
    Friend DA30 As New MySqlDataAdapter
    Friend DS30 As New DataSet()
    Friend DT30 As New DataTable

    Friend conexion31 As New MySqlConnection ' Login
    Friend SC31 As New MySqlCommand
    Friend DA31 As New MySqlDataAdapter
    Friend DS31 As New DataSet()
    Friend DT31 As New DataTable

    Friend conexion32 As New MySqlConnection ' Cargar datos usuarios
    Friend SC32 As New MySqlCommand
    Friend DA32 As New MySqlDataAdapter
    Friend DS32 As New DataSet()
    Friend DT32 As New DataTable

    Friend conexion33 As New MySqlConnection ' Modifica Datos
    Friend SC33 As New MySqlCommand
    Friend DA33 As New MySqlDataAdapter
    Friend DS33 As New DataSet()
    Friend DT33 As New DataTable

    Friend conexion34 As New MySqlConnection ' Agrega Datos
    Friend SC34 As New MySqlCommand
    Friend DA34 As New MySqlDataAdapter
    Friend DS34 As New DataSet()
    Friend DT34 As New DataTable

    Friend conexion35 As New MySqlConnection ' Busca usuarios
    Friend SC35 As New MySqlCommand
    Friend DA35 As New MySqlDataAdapter
    Friend DS35 As New DataSet()
    Friend DT35 As New DataTable

    Friend conexion36 As New MySqlConnection ' Elinina usuarios
    Friend SC36 As New MySqlCommand
    Friend DA36 As New MySqlDataAdapter
    Friend DS36 As New DataSet()
    Friend DT36 As New DataTable

    Friend conexion37 As New MySqlConnection ' Detalle vencimientos
    Friend SC37 As New MySqlCommand
    Friend DA37 As New MySqlDataAdapter
    Friend DS37 As New DataSet()
    Friend DT37 As New DataTable

    Friend conexion38 As New MySqlConnection ' Listar compras
    Friend SC38 As New MySqlCommand
    Friend DA38 As New MySqlDataAdapter
    Friend DS38 As New DataSet()
    Friend DT38 As New DataTable

    Friend conexion39 As New MySqlConnection ' Cargar detalle de venta
    Friend SC39 As New MySqlCommand
    Friend DA39 As New MySqlDataAdapter
    Friend DS39 As New DataSet()
    Friend DT39 As New DataTable

    Friend conexion40 As New MySqlConnection ' Buscar compra por numero de factura
    Friend SC40 As New MySqlCommand
    Friend DA40 As New MySqlDataAdapter
    Friend DS40 As New DataSet()
    Friend DT40 As New DataTable

    Friend conexion41 As New MySqlConnection ' Buscar compra por fecha
    Friend SC41 As New MySqlCommand
    Friend DA41 As New MySqlDataAdapter
    Friend DS41 As New DataSet()
    Friend DT41 As New DataTable

    Friend conexion42 As New MySqlConnection ' Buscar compra por proveedor
    Friend SC42 As New MySqlCommand
    Friend DA42 As New MySqlDataAdapter
    Friend DS42 As New DataSet()
    Friend DT42 As New DataTable

    Friend conexion43 As New MySqlConnection ' Cargar Proveedores
    Friend SC43 As New MySqlCommand
    Friend DA43 As New MySqlDataAdapter
    Friend DS43 As New DataSet()
    Friend DT43 As New DataTable

    Friend conexion44 As New MySqlConnection ' Modificar Proveedor
    Friend SC44 As New MySqlCommand
    Friend DA44 As New MySqlDataAdapter
    Friend DS44 As New DataSet()
    Friend DT44 As New DataTable

    Friend conexion45 As New MySqlConnection ' Buscar Proveedor
    Friend SC45 As New MySqlCommand
    Friend DA45 As New MySqlDataAdapter
    Friend DS45 As New DataSet()
    Friend DT45 As New DataTable

    Friend conexion46 As New MySqlConnection ' Agregar proveedor
    Friend SC46 As New MySqlCommand
    Friend DA46 As New MySqlDataAdapter
    Friend DS46 As New DataSet()
    Friend DT46 As New DataTable

    Friend conexion47 As New MySqlConnection ' Eliminar Proveedor
    Friend SC47 As New MySqlCommand
    Friend DA47 As New MySqlDataAdapter
    Friend DS47 As New DataSet()
    Friend DT47 As New DataTable

    Friend conexion48 As New MySqlConnection ' Numero de compra
    Friend SC48 As New MySqlCommand
    Friend DA48 As New MySqlDataAdapter
    Friend DS48 As New DataSet()
    Friend DT48 As New DataTable

    Friend conexion49 As New MySqlConnection ' Sumar stock
    Friend SC49 As New MySqlCommand
    Friend DA49 As New MySqlDataAdapter
    Friend DS49 As New DataSet()
    Friend DT49 As New DataTable

    Friend conexion50 As New MySqlConnection ' Guardar Compra
    Friend SC50 As New MySqlCommand
    Friend DA50 As New MySqlDataAdapter
    Friend DS50 As New DataSet()
    Friend DT50 As New DataTable

    Friend conexion51 As New MySqlConnection ' Guardar Compra
    Friend SC51 As New MySqlCommand
    Friend DA51 As New MySqlDataAdapter
    Friend DS51 As New DataSet()
    Friend DT51 As New DataTable

    Friend conexion52 As New MySqlConnection ' Guardar Compra
    Friend SC52 As New MySqlCommand
    Friend DA52 As New MySqlDataAdapter
    Friend DS52 As New DataSet()
    Friend DT52 As New DataTable

    Friend conexion53 As New MySqlConnection ' Modificar Categoria
    Friend SC53 As New MySqlCommand
    Friend DA53 As New MySqlDataAdapter
    Friend DS53 As New DataSet()
    Friend DT53 As New DataTable

    Friend conexion54 As New MySqlConnection ' Eliminar Categoria
    Friend SC54 As New MySqlCommand
    Friend DA54 As New MySqlDataAdapter
    Friend DS54 As New DataSet()
    Friend DT54 As New DataTable

    Friend conexion55 As New MySqlConnection ' REPORTE
    Friend SC55 As New MySqlCommand
    Friend DA55 As New MySqlDataAdapter
    Friend DS55 As New DataSet()
    Friend DT55 As New DataTable

    Friend conexion56 As New MySqlConnection ' ELIMINAR VENTA o COMPRA
    Friend SC56 As New MySqlCommand
    Friend DA56 As New MySqlDataAdapter
    Friend DS56 As New DataSet()
    Friend DT56 As New DataTable

    Friend conexion57 As New MySqlConnection ' Desactivar o desactivar usuario
    Friend SC57 As New MySqlCommand
    Friend DA57 As New MySqlDataAdapter
    Friend DS57 As New DataSet()
    Friend DT57 As New DataTable

End Module