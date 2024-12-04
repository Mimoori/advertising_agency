window.addEventListener('scroll', function () {
    const footer = document.getElementById('footer');

    // Проверяем, достигли ли мы конца страницы
    if ((window.innerHeight + window.scrollY) >= document.body.offsetHeight) {
        footer.classList.remove('hidden'); // Показываем подвал
        footer.style.display = 'block'; // Убедимся, что он отображается
    } else {
        footer.classList.add('hidden'); // Скрываем подвал
        footer.style.display = 'none'; // Убедимся, что он скрыт
    }
});