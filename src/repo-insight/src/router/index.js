import { createRouter, createWebHistory } from 'vue-router'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    {
      path: '/signIn',
      name: 'SignIn',
      component: () => import('@/views/SignIn.vue')
    },
    {
    path: "/registerForm",
    name: "registerForm",
    component: registerForm,
  },
  ]
})

export default router;
