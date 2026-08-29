document.getElementById('entrarSala').onclick = function () {
    const usuario = document.getElementById('usuario').value;
    const nomeSala = document.getElementById('nomeSala').value;

    if (!usuario || !nomeSala) {
        alert("Preencha usuário e sala!");
        return;
    }

    sessionStorage.setItem("usuario", usuario);
    sessionStorage.setItem("nomeSala", nomeSala);

    window.location.href = "/Home/Index";
};
