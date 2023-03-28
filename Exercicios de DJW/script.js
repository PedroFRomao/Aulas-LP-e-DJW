function trocarImagem() {
  var imagens = ["imagem1.jpg", "imagem2.jpg", "imagem3.jpg"];
  var novaImagem = imagens[Math.floor(Math.random() * imagens.length)];
  document.getElementById("imagem").src = novaImagem;
}
