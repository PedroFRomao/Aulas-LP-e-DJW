function trocarImagem() {
  let imagem = document.getElementById("imagem");
  let aleatorio = Math.trunc (Math.random()*10);
  imagem.src = "img/imagem" + aleatorio + ".jpg";
}
