<template>
    <div class="container">
      <main class="container my-5">
        <div class="row justify-content-center">
          <div class="col-lg-6">
            <form @submit.prevent="onSubmit()" id="login-form" class="p-4 rounded form-container">
              <h2 class="text-center mb-4">Fazer Login</h2>
              <div class="bool">ou</div>
              <!-- Option to login with GitHub -->
              <div class="mb-4 text-center">
                  <button type="button" class="btn btn-dark">
                    <i class="fab fa-github me-2"></i>  conecte-se com GitHub
                  </button>
              </div>
    
  
              <!-- Email field -->
              <div class="mb-3">
                <label for="user-email" class="form-label">E-mail</label>
                <input name="user-email" class="form-control" type="email" placeholder="Digite seu e-mail" required v-model="email">
                <!-- <small class="text-danger">Preencha o campo E-mail</small> Error message for email -->
              </div>
  
              <!-- Password field -->
              <div class="mb-3 position-relative">
                <label for="user-password" class="form-label">Senha</label>
                <div class="input-group">
                  <input id="user-password" name="user-password" class="form-control" placeholder="Digite sua senha" required v-bind:type="showPassword ? 'text' : 'password'" v-model="password">
                  <span class="input-group-text" @click="showPassword = !showPassword">
                    <i v-if="showPassword" class="fas fa-eye-slash"></i>
                    <i v-else class="fas fa-eye"></i>
                  </span>
                </div>
                <!-- <small class="text-danger">Preencha o campo Senha</small> Error message for password -->
              </div>
  
              <!-- Login button -->
              <button id="button" type="submit" class="btn btn-primary w-100">Entrar</button>
  
              <!-- Link to register a new account -->
              <div class="text-center mt-3">
                <p>Não possui uma conta? <a href="login.html" class="text-decoration-none">Faça seu Cadastro</a></p>
              </div>
            </form>
          </div>
        </div>
      </main>
    </div>
  </template>
  
  <script>
  import { ref } from "vue";
  
  export default {
    name: "SignForm",
    props: {
      errorMsg: Object, // Prop to store error messages
    },
    data() {
      return {
        showPassword: false,
        // Removendo a chave password do objeto de dados
      }
    },
  
    setup(props, { emit }) {
      const password = ref("");
      const email = ref("");
      const error = ref({ email: '', password: '' }); // Initialize error messages
  
      const onSubmit = () => {
        // Clear previous error messages
        error.value = { email: '', password: '' };
  
        // If email or password is not filled, show error message
        if (!email.value.trim()) {
          error.value.email = "Por favor, preencha o campo de e-mail.";
        }
  
        if (!password.value.trim()) {
          error.value.password = "Por favor, preencha o campo de senha.";
        }
  
        // If there are no errors, emit onSubmit event
        if (!error.value.email && !error.value.password) {
          emit("onSubmit", { email: email.value, password: password.value });
        }
      };
  
      return {
        error,
        password,
        email,
        onSubmit
      };
    },
  };
  </script>
  
  <style >
    body {
      background: linear-gradient(to bottom right, #000, #01153a);
    }
    .bool {
      margin-top: -20px;
      margin-bottom: 5px;
    }
    .form-container {
      background-color: white;
      border-radius: 20px;
      box-shadow: 0px 0px 20px #0056b3;
    }
    #button {
      background-color: #01153a;
    }
    #button:hover {
      background-color: #031e52;
    }
    .text-danger{
      color: darkred;
    }
    .form-control:focus {
      outline: none !important;
      box-shadow: none !important;
    }
  </style>
  