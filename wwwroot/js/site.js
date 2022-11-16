function valida_formulario(form) {   

    var nome = document.getElementById('Nome');    
    var descricao = document.getElementById('Descricao');    

    var caixa_nome = document.querySelector('.msg-nome');
    caixa_nome.style.display = 'none';
       
    var caixa_descricao = document.querySelector('.msg-descricao');
    caixa_descricao.style.display = 'none'; 
    
    
    if (nome.value==""){
        caixa_nome.innerHTML = "Campo obrigatório";
        caixa_nome.style.display = 'block';               
        nome.focus();        
        return false;
    }   
    
    if (descricao.value==""){
        caixa_descricao.innerHTML = "Campo obrigatório";
        caixa_descricao.style.display = 'block'; 
        descricao.focus();
        return false;
    } 

    return true;

}

function valida_cadastro(cadastro) {

    var invalid = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/; //expressao regular  

    var nome = document.getElementById('Nome');
    var email = document.getElementById('Email');
    var login = document.getElementById('Login');
    var senha = document.getElementById('Senha');

    var caixa_nome = document.querySelector('.msg-nome');
    caixa_nome.style.display = 'none';

    var caixa_email = document.querySelector('.msg-email');
    caixa_email.style.display = 'none';
    
    var caixa_login = document.querySelector('.msg-login');
    caixa_login.style.display = 'none';
    
    var caixa_senha = document.querySelector('.msg-senha');
    caixa_senha.style.display = 'none';
    
    
    if (nome.value==""){
        caixa_nome.innerHTML = "Campo obrigatório";
        caixa_nome.style.display = 'block';               
        nome.focus();        
        return false;
    }

    if (email.value==""){
        caixa_email.innerHTML = "Campo obrigatório";
        caixa_email.style.display = 'block'; 
        email.focus();
        return false;
    }

    if (invalid.test(email.value)==false){
        caixa_email.innerHTML = "E-mail informado incorreto";
        caixa_email.style.display = 'block';        
        email.focus();
        return false;

    }

    if (login.value==""){
        caixa_login.innerHTML = "Campo obrigatório";
        caixa_login.style.display = 'block'; 
        login.focus();
        return false;
    }

    if (senha.value==""){
        caixa_senha.innerHTML = "Campo obrigatório";
        caixa_senha.style.display = 'block'; 
        senha.focus();
        return false;
    }   

    return true;

}