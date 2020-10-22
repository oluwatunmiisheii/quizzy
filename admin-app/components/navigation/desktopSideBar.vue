<template>
  <div class="hidden lg:flex lg:flex-shrink-0">
    <div class="flex flex-col w-64">
      <div class="flex flex-col flex-grow bg-teal-600 pt-5 pb-4 overflow-y-auto h-screen">
        <!-- logo -->
        <div class="flex items-center flex-shrink-0 px-4">
          <img class="h-8 w-auto" src="https://tailwindui.com/img/logos/easywire-logo-on-brand.svg" alt="Easywire logo">
        </div>

        <!-- main sidebar -->
        <div class="mt-6 flex-1 flex flex-col overflow-y-auto">
          <div class="overflow-y-auto">
            <nav class="px-2 space-y-1">
              <!-- dashboard -->
              <nuxt-link
                :to="({path: '/dashboard'})"
                class="quizzy-nav__menu"
              >
                <dashboard-icon />
                Dashboard
              </nuxt-link>

              <!-- users -->
              <nuxt-link
                :to="({path: '/users'})"
                class="quizzy-nav__menu"
              >
                <users-icon/>
                Users
              </nuxt-link>

              <!-- leaderboard -->
              <nuxt-link
                :to="({path: '/leaderboard'})"
                class="quizzy-nav__menu"
              >
                <leader-board-icon />
                Leaderboard
              </nuxt-link>

              <!-- categories -->
              <nuxt-link 
                :to="({path: '/categories'})"
                class="quizzy-nav__menu"
              >
                <categories-icon />
                Categories
              </nuxt-link>

              <!-- questions -->
              <a 
                href="#" 
                class="quizzy-nav__menu"
              >
                <questions-icon />
                Questions
              </a>
            </nav>
          </div>

          <!-- border divider -->
          <hr class="h-px mt-6 bg-teal-700 border-none">
          
          <!-- other nav menu -->
          <div class="mt-6 flex-1 h-0 overflow-y-auto">
            <nav class="px-2 space-y-1">
              <!-- settings -->
              <a 
                href="#" 
                class="quizzy-nav__menu"
              >
                <settings-icon />
                Settings
              </a>

              <!-- logout -->
              <a 
                href="#" 
                class="quizzy-nav__menu"
              >
                <logout-icon />
                Logout
              </a>
            </nav>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
const DashboardIcon = () => import('@/components/vectors/dashboard')
const UsersIcon = () => import('@/components/vectors/users')
const LeaderBoardIcon = () => import('@/components/vectors/leaderboard')
const CategoriesIcon = () => import('@/components/vectors/categories')
const QuestionsIcon = () => import('@/components/vectors/questions')
const SettingsIcon = () => import('@/components/vectors/settings')
const logoutIcon = () => import('@/components/vectors/logout')

export default {
  components: {
    DashboardIcon,
    LeaderBoardIcon,
    UsersIcon,
    CategoriesIcon,
    QuestionsIcon,
    SettingsIcon,
    logoutIcon
  }
}
</script>

<style scoped>
.quizzy-nav__menu {
  @apply flex;
  @apply items-center;
  @apply px-2;
  @apply py-2;
  @apply text-sm;
  @apply leading-6;
  @apply font-medium;
  @apply rounded-md;
  @apply text-teal-100;
  @apply transition;
  @apply ease-in-out;
  @apply duration-150
}
.quizzy-nav__menu:hover {
  @apply text-white;
  @apply bg-teal-500;
}
.quizzy-nav__menu:hover {
  @apply text-white;
  @apply bg-teal-500;
}

.nuxt-link-active {
  @apply bg-teal-700;
  @apply text-white;
  @apply outline-none
}
</style>