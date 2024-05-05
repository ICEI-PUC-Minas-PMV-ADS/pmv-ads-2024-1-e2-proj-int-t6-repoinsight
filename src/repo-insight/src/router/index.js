import { createRouter, createWebHistory } from 'vue-router'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    {
      path: '/signIn',
      name: 'SignIn',
      component: () => import('@/views/SignIn.vue')
    },
    // Adicione outras rotas conforme necessário
  ]
})

export default router;
