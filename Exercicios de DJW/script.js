var imagens = ["imagem1.jpg", "imagem2.jpg", "imagem3.jpg", "imagem4.jpg", "imagem5.jpg", "imagem6.jpg", "imagem7.jpg", "imagem8.jpg", "imagem9.jpg", "imagem10.jpg"];
var indiceImagemAtual = 0;

function trocarImagem() {
  var novaImagem;
  do {
    novaImagem = imagens[Math.floor(Math.random() * imagens.length)];
  } while (novaImagem == document.getElementById("imagem").src);
  document.getElementById("imagem").src = novaImagem;
  indiceImagemAtual = imagens.indexOf(novaImagem);
}

function trocarImagemAnterior() {
  if (indiceImagemAtual > 0) {
    var imagemAnterior = imagens[indiceImagemAtual - 1];
    document.getElementById("imagem").src = imagemAnterior;
    indiceImagemAtual--;
  }
}
