<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Página Estilizada con Navbar y Modal</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <nav class="navbar">
        <div class="logo">Mi Sitio Web</div>
        <ul class="nav-links">
            <li><a href="#">Inicio</a></li>
            <li><a href="#">Acerca de</a></li>
            <li><a href="#">Servicios</a></li>
            <li><a href="#">Contacto</a></li>
            <li><button class="login-btn" onclick="abrirModal()">Iniciar Sesión</button></li>
        </ul>
    </nav>

    <div class="content">
        <div class="info">
            <h1>Bienvenido a Mi Sitio Web</h1>
            <h2>asdasdasdas</h2>
            <p>Este es un texto de muestra para demostrar el diseño.</p>
        </div>
    </div>

    <span class="scroll-down">
        <button onclick="irASeccion()">
            &#x21E9; &#x21E9;
        </button>
    </span>

    <div id="more-info">
        <h2>Más Información</h2>
        <p>Contenido adicional aquí.</p>
    </div>

    <div id="modal" class="modal">
        <div class="modal-content">
            <span class="close-btn" onclick="cerrarModal()">&times;</span>
            <h2>Iniciar Sesión</h2>
            <form>
                <label for="email">Correo Electrónico</label>
                <input type="text" id="email" name="email" placeholder="johndoe@example.com">
                <label for="password">Contraseña</label>
                <input type="password" id="password" name="password" placeholder="Contraseña">
                <button type="submit">Iniciar Sesión</button>
                <p>¿No tienes una cuenta? <a href="#">Regístrate</a></p>
            </form>
        </div>
    </div>

    <script src="scripts.js"></script>
</body>
</html>
