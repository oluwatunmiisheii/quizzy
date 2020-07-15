<template>
  <nav class="flex items-center justify-between flex-wrap p-6 lg:shadow bg-white lg:border lg:border-gray lg:rounded-md">
    <!-- nav logo -->
    <div class="flex items-center flex-shrink-0 text-white mr-6">
      <span class="font-semibold text-xl tracking-tight text-black">Quizzy</span>
    </div>

    <!-- toggler on mobile -->
    <div class="block lg:hidden">
      <button
        class="flex items-center px-3 py-2 border rounded text-teal-200 border-teal-400 hover:text-white hover:border-white">
        <svg class="fill-current h-3 w-3" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
          <title>Menu</title>
          <path d="M0 3h20v2H0V3zm0 6h20v2H0V9zm0 6h20v2H0v-2z" />
        </svg>
      </button>
    </div>

    <!-- nav links -->
    <div class="w-full block flex-grow lg:justify-end lg:flex lg:items-center lg:w-auto">
      <div class="text-sm">
        <a href="#responsive-header" class="block mt-4 lg:inline-block text-gray-700 lg:mt-0 hover:text-blue-700 mr-5">Profile</a>
        <a href="#responsive-header" class="block mt-4 lg:inline-block text-gray-700 lg:mt-0 hover:text-blue-700 mr-5">Leaderboard</a>
        <a href="#responsive-header" class="block mt-4 lg:inline-block text-gray-700 lg:mt-0 hover:text-blue-700 mr-5">Sign In</a>
        <a 
          href="#"
          class="inline-block text-sm px-4 py-2 leading-none border rounded text-white border-blue-700 bg-blue-700 hover:border-transparent hover:shadow mt-4 lg:mt-0"
          @click.prevent="showRegisterModal"
        >Sign Up
        </a>
      </div>
    </div>
  </nav>
</template>


<script>
export default {
  methods: {
    showRegisterModal() {
      this.$modal.show('example')
    }
  }
}
</script>