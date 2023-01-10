
const menuItems = document.querySelectorAll('.menu-items');

const messagesNotification = document.querySelector
('#messages-notification');
const message = document.querySelector('.message');


const changActiveItems = () =>{
    menuItems.forEach(item => {
        item.classList.remove('active');
    })
}


menuItems.forEach(item =>{
    item.addEventListener('click',()=>{
        changActiveItems();
        item.classList.add('active');
        if(item.id != 'notifications'){
            document.querySelector('.notifications-popup').style.display = "none";
        }
        else{ 
            document.querySelector('.notifications-popup').style.display = "block";
            document.querySelector('#notifications .notification-count').style.display='none';
        }
    })
})

messagesNotification.addEventListener('click', () => {
    message.style.boxShadow = '0 0 1rem  var(--color-primary)';
    messagesNotification.querySelector('.notification-count').style.display ='none';
    setTimeout(() => {
        message.style.boxShadow = "none";
    },2000);
})

