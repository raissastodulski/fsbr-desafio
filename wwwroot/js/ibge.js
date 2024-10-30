function aoSelecionarUf() {
    selectUfs = document.getElementById("Uf");
    selectMunicipios = document.getElementById("Municipio");
    ufSelecionada = selectUfs.value;
    console.log(ufSelecionada);

    selectMunicipios.innerHTML = '<option selected>Selecione um município</option>';
    var cidades = buscarCidades(ufSelecionada)
    for (let i = 0; i < cidades.length; i++) {
        adicionarOpcao(selectMunicipios, cidades[i].nome, cidades[i].nome);
    }
}

function adicionarOpcao(select, valor, texto)
{
    var opcao = document.createElement("option");
    opcao.value = valor;
    opcao.text = texto;
    select.add(opcao, null);
}

function buscarCidades(uf) {
    var Url = "/Processo/Municipios/";
    var cidades = null;

    console.log($);
    $.ajax({
        type: "GET",
        url: Url,
        data: { 
            "uf": uf
        },
        dataType: "json",
        cache: false,
        async: false,
        success: function (response, status, xhr) {
            cidades = response;
        }
    });
    return cidades;
}