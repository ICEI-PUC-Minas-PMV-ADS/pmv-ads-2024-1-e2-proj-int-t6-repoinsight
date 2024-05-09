<template>
  <div>
    <h2>Cadastro de Usuário</h2>
    <form @submit.prevent="submitForm">
      <div>
        <label for="name">Nome:</label>
        <input type="text" id="name" v-model="formData.name" required />
      </div>
      <div>
        <label for="email">E-mail:</label>
        <input type="email" id="email" v-model="formData.email" required />
      </div>
      <div>
        <label for="password">Senha:</label>
        <input
          type="password"
          id="password"
          v-model="formData.password"
          required
        />
      </div>
      <button type="submit">Cadastrar</button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      formData: {
        name: "",
        email: "",
        password: "",
      },
    };
  },
  methods: {
    submitForm() {
      this.formData = {
        name: "",
        email: "",
        password: "",
      };
    },
  },
};
</script>

<style scoped>

body {
  background: linear-gradient(to bottom right, #000, #01153a);
}
form {
  max-width: 400px;
  margin: auto;
}

label {
  display: block;
  margin-bottom: 5px;
}

input[type="text"],
input[type="email"],
input[type="password"] {
  width: 100%;
  padding: 8px;
  margin-bottom: 10px;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
}

button {
  padding: 10px 20px;
  background-color: #007bff;
  color: #fff;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}
</style>
