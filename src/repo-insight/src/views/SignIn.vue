<template>
    <main>
      <SignInForm @onSubmit="submitLoginForm" />
    </main>
</template>
  
<script>
  import SignInForm from '@/components/SignInForm.vue';
  import axios from 'axios';
  
  export default {
    components: {
      SignInForm
    },
    methods: {
      async submitLoginForm(credentials) {
        try {
          const response = await axios.post('http://localhost:5000/login/authenticate', {
            email: credentials.email,
            password: credentials.password
          });
          if (response.status === 200) {
            alert('Logou');
          } else {
            alert('Usuário não encontrado');
          }
        } catch (error) {
          console.error(error);
          alert('Erro ao fazer login');
        }
      }
    }
  }
</script>
  
  
  