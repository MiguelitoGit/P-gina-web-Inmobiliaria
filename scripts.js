function abrirModal() {
    document.getElementById('modal').style.display = 'flex';
}

function cerrarModal() {
    document.getElementById('modal').style.display = 'none';
}

function irASeccion() {
    document.getElementById('more-info').scrollIntoView({ behavior: 'smooth' });
}
