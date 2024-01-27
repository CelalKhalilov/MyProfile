let isLiked = false;
let likeCount = 0; // Başlangıç beğeni sayısı, örneğin 20.4k için 20400

function toggleLike() {
  const likeIcon = document.getElementById("like-icon");
  const likeCountElement = document.getElementById("like-count");

  if (isLiked) {
    // Kullanıcı daha önce beğeni yapmışsa
    likeIcon.classList.remove("fas");
    likeIcon.classList.add("far");
    likeCount -= 1;
  } else {
    // Kullanıcı daha önce beğeni yapmamışsa
    likeIcon.classList.remove("far");
    likeIcon.classList.add("fas");
    likeCount += 1;
  }

  // Beğeni durumunu güncelle
  isLiked = !isLiked;

  // Beğeni sayısını güncelle
  likeCountElement.textContent = likeCount.toLocaleString(); // 20.4k gibi göstermek için
}
