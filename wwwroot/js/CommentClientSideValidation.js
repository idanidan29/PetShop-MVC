//comment
const commentInput = document.getElementById('comment');
const commentError = document.getElementById('comment-error');

commentInput.addEventListener('input', function () {
    const comment = commentInput.value.trim();
    if (comment.length < 5) {
        commentError.textContent = 'Comment must be at least 5 characters';
        commentInput.setCustomValidity('Comment must be at least 5 characters');
    } else if (comment.length > 1000) {
        commentError.textContent = 'Comment must be no more than 1000 characters';
        commentInput.setCustomValidity('Comment must be no more than 1000 characters');
    } else {
        commentError.textContent = '';
        commentInput.setCustomValidity('');
    }
});