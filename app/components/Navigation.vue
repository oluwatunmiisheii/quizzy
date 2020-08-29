<template>
  <nav class="bg-white shadow">
    <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-20">
      <div class="flex justify-between h-16">
        <div class="flex">
          <div class="flex-shrink-0 flex items-center">
            <img class="block lg:hidden h-8 w-auto" src="https://tailwindui.com/img/logos/workflow-mark-on-white.svg" alt="Workflow logo">
            <img class="hidden lg:block h-8 w-auto" src="https://tailwindui.com/img/logos/workflow-logo-on-white.svg" alt="Workflow logo">
          </div>
          <div class="hidden sm:ml-6 sm:flex">
            <nuxt-llink
              to='/leaderboard'
              tag="a"
              class="pointer inline-flex items-center px-1 pt-1 border-b-2 border-indigo-500 text-sm font-medium leading-5 text-gray-900 focus:outline-none focus:border-indigo-700 transition duration-150 ease-in-out"
            >
              Leaderboard
            </nuxt-llink>
            <a 
              href="#" 
              class="ml-8 inline-flex items-center px-1 pt-1 border-b-2 border-transparent text-sm font-medium leading-5 text-gray-500 hover:text-gray-700 hover:border-gray-300 focus:outline-none focus:text-gray-700 focus:border-gray-300 transition duration-150 ease-in-out"
            >
              Profile
            </a>
          </div>
        </div>
        <div class="hidden sm:ml-6 sm:flex sm:items-center">
          <div class="flex-shrink-0 md:mr-8">
            <a 
              href="#"  
              @click.prevent="showAuthModal('Sign In')" 
              class="relative inline-flex items-center text-sm font-medium leading-5 text-gray-900"
            >
              <svg class="-ml-1 mr-2 h-5 w-5" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M16 7a4 4 0 11-8 0 4 4 0 018 0zM12 14a7 7 0 00-7 7h14a7 7 0 00-7-7z"/>
              </svg>
              <span>Sign In</span>
            </a>
          </div>

          <div class="flex-shrink-0 md:mr-6">
            <button 
              @click.prevent="showAuthModal('Sign Up')"
              type="button" 
              class="relative inline-flex items-center px-4 py-2 border border-transparent text-sm leading-5 font-medium rounded-md text-white bg-indigo-600 shadow-sm hover:bg-indigo-500 focus:outline-none focus:border-indigo-700 focus:shadow-outline-indigo active:bg-indigo-700 transition ease-in-out duration-150"
            >
              <svg class="-ml-1 mr-2 h-5 w-5" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M18 9v3m0 0v3m0-3h3m-3 0h-3m-2-5a4 4 0 11-8 0 4 4 0 018 0zM3 20a6 6 0 0112 0v1H3v-1z"/>
              </svg>
              <span>Sign Up</span>
            </button>
          </div>

          <!-- Profile dropdown -->
          <div class="ml-3 relative">
            <div>
              <button class="flex text-sm border-2 border-transparent rounded-full focus:outline-none focus:border-gray-300 transition duration-150 ease-in-out" id="user-menu" aria-label="User menu" aria-haspopup="true">
                <span class="inline-block h-8 w-8 rounded-full overflow-hidden bg-gray-100">
                  <svg class="h-full w-full text-gray-700" fill="currentColor" viewBox="0 0 24 24">
                    <path d="M24 20.993V24H0v-2.996A14.977 14.977 0 0112.004 15c4.904 0 9.26 2.354 11.996 5.993zM16.002 8.999a4 4 0 11-8 0 4 4 0 018 0z" />
                  </svg>
                </span>
              </button>
            </div>
            <div class="origin-top-right absolute right-0 mt-2 w-48 rounded-md shadow-lg">
              <div class="py-1 rounded-md bg-white shadow-xs hidden" role="menu" aria-orientation="vertical" aria-labelledby="user-menu">
                <a href="#" class="block px-4 py-2 text-sm leading-5 text-gray-700 hover:bg-gray-100 focus:outline-none focus:bg-gray-100 transition duration-150 ease-in-out" role="menuitem">Your Profile</a>
                <a href="#" class="block px-4 py-2 text-sm leading-5 text-gray-700 hover:bg-gray-100 focus:outline-none focus:bg-gray-100 transition duration-150 ease-in-out" role="menuitem">Settings</a>
                <a href="#" class="block px-4 py-2 text-sm leading-5 text-gray-700 hover:bg-gray-100 focus:outline-none focus:bg-gray-100 transition duration-150 ease-in-out" role="menuitem">Sign out</a>
              </div>
            </div>
          </div>
        </div>

        <div class="-mr-2 flex items-center sm:hidden">
          <!-- Mobile menu button -->
          <button 
            class="inline-flex items-center justify-center p-2 rounded-md text-gray-400 hover:text-gray-500 hover:bg-gray-100 focus:outline-none focus:bg-gray-100 focus:text-gray-500 transition duration-150 ease-in-out" 
            aria-label="Main menu" 
            aria-expanded="false"
          >
            <!-- Icon when menu is closed. -->
            <!-- Menu open: "hidden", Menu closed: "block" -->
            <svg class="block h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor">
              <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h16M4 18h16" />
            </svg>
            <!-- Icon when menu is open. -->
            <!-- Menu open: "block", Menu closed: "hidden" -->
            <svg class="hidden h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor">
              <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M6 18L18 6M6 6l12 12" />
            </svg>
          </button>
        </div>
      </div>
    </div>

    <!-- nav menu on mobile -->
    <div class="hidden sm:hidden">
      <div class="pt-2 pb-3">
        <a href="#" class="block pl-3 pr-4 py-2 border-l-4 border-indigo-500 text-base font-medium text-indigo-700 bg-indigo-50 focus:outline-none focus:text-indigo-800 focus:bg-indigo-100 focus:border-indigo-700 transition duration-150 ease-in-out">Dashboard</a>
        <a href="#" class="mt-1 block pl-3 pr-4 py-2 border-l-4 border-transparent text-base font-medium text-gray-600 hover:text-gray-800 hover:bg-gray-50 hover:border-gray-300 focus:outline-none focus:text-gray-800 focus:bg-gray-50 focus:border-gray-300 transition duration-150 ease-in-out">Team</a>
        <a href="#" class="mt-1 block pl-3 pr-4 py-2 border-l-4 border-transparent text-base font-medium text-gray-600 hover:text-gray-800 hover:bg-gray-50 hover:border-gray-300 focus:outline-none focus:text-gray-800 focus:bg-gray-50 focus:border-gray-300 transition duration-150 ease-in-out">Projects</a>
        <a href="#" class="mt-1 block pl-3 pr-4 py-2 border-l-4 border-transparent text-base font-medium text-gray-600 hover:text-gray-800 hover:bg-gray-50 hover:border-gray-300 focus:outline-none focus:text-gray-800 focus:bg-gray-50 focus:border-gray-300 transition duration-150 ease-in-out">Calendar</a>
      </div>
      <div class="pt-4 pb-3 border-t border-gray-200">
        <div class="flex items-center px-4">
          <div class="flex-shrink-0">
            <img class="h-10 w-10 rounded-full" src="https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=facearea&facepad=2&w=256&h=256&q=80" alt="">
          </div>
          <div class="ml-3">
            <div class="text-base font-medium leading-6 text-gray-800">Tom Cook</div>
            <div class="text-sm font-medium leading-5 text-gray-500">tom@example.com</div>
          </div>
        </div>
        <div class="mt-3">
          <a href="#" class="block px-4 py-2 text-base font-medium text-gray-500 hover:text-gray-800 hover:bg-gray-100 focus:outline-none focus:text-gray-800 focus:bg-gray-100 transition duration-150 ease-in-out">Your Profile</a>
          <a href="#" class="mt-1 block px-4 py-2 text-base font-medium text-gray-500 hover:text-gray-800 hover:bg-gray-100 focus:outline-none focus:text-gray-800 focus:bg-gray-100 transition duration-150 ease-in-out">Settings</a>
          <a href="#" class="mt-1 block px-4 py-2 text-base font-medium text-gray-500 hover:text-gray-800 hover:bg-gray-100 focus:outline-none focus:text-gray-800 focus:bg-gray-100 transition duration-150 ease-in-out">Sign out</a>
        </div>
      </div>
    </div>
  </nav>
</template>


<script>
export default {
  data() {
    return {
      
    }
  },
  methods: {
    showAuthModal(type) {
      this.$store.dispatch('auth/getAuthFormState', type).then(() => {
        this.$modal.show('auth')
      })
    }
  }
}
</script>

// <nav class="bg-white shadow">
//     <!-- nav logo -->
//     <div class="flex items-center flex-shrink-0 text-white mr-6">
//       <span class="font-semibold text-xl tracking-tight text-black">Quizzy</span>
//     </div>

//     <!-- toggler on mobile -->
//     <div class="block lg:hidden">
//       <button
//         class="flex items-center px-3 py-2 border rounded text-teal-200 border-teal-400 hover:text-white hover:border-white">
//         <svg class="fill-current h-3 w-3" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
//           <title>Menu</title>
//           <path d="M0 3h20v2H0V3zm0 6h20v2H0V9zm0 6h20v2H0v-2z" />
//         </svg>
//       </button>
//     </div>

//     <!-- nav links -->
//     <div class="w-full block flex-grow lg:justify-end lg:flex lg:items-center lg:w-auto">
//       <div class="text-sm">
//         <a href="#responsive-header" class="block mt-4 lg:inline-block text-gray-700 lg:mt-0 hover:text-blue-700 mr-5">Profile</a>
//         <router-link :to="({path: '/leaderboard'})" class="block mt-4 lg:inline-block text-gray-700 lg:mt-0 hover:text-blue-700 mr-5">Leaderboard</router-link>
//         <a 
//           href="#" 
//           class="block mt-4 lg:inline-block text-gray-700 lg:mt-0 hover:text-blue-700 mr-5"
//           @click.prevent="showAuthModal('Sign In')"
//         >Sign In</a>
//         <a 
//           href="#"
//           class="inline-block text-sm px-4 py-2 leading-none border rounded text-white border-blue-700 bg-blue-700 hover:border-transparent hover:shadow mt-4 lg:mt-0"
//           @click.prevent="showAuthModal('Sign Up')"
//         >Sign Up
//         </a>
//       </div>
//     </div>
//   </nav>