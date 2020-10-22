<template>
  <div class="relative z-10 flex-shrink-0 flex h-16 bg-white border-b border-gray-200 lg:border-none">
    <button
      class="px-4 border-r border-cool-gray-200 text-cool-gray-400 focus:outline-none focus:bg-cool-gray-100 focus:text-cool-gray-600 lg:hidden"
      aria-label="Open sidebar"
    >
      <svg class="h-6 w-6 transition ease-in-out duration-150" fill="none" viewBox="0 0 24 24" stroke="currentColor">
        <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h8m-8 6h16" />
      </svg>
    </button>
    <!-- Search bar -->
    <div class="flex-1 px-4 flex justify-between sm:px-6 lg:max-w-6xl lg:mx-auto lg:px-8">
      <div class="flex-1 flex">
        <form class="w-full flex md:ml-0 lg:hidden">
          <label for="search_field" class="sr-only">Search</label>
          <div class="relative w-full text-cool-gray-400 focus-within:text-cool-gray-600">
            <div class="absolute inset-y-0 left-0 flex items-center pointer-events-none">
              <svg 
                class="h-5 w-5" 
                fill="currentColor" 
                viewBox="0 0 20 20"
              >
                <path 
                  fill-rule="evenodd" 
                  clip-rule="evenodd"
                  d="M8 4a4 4 0 100 8 4 4 0 000-8zM2 8a6 6 0 1110.89 3.476l4.817 4.817a1 1 0 01-1.414 1.414l-4.816-4.816A6 6 0 012 8z" 
                />
              </svg>
            </div>
            <input 
              id="search_field"
              class="block w-full h-full pl-8 pr-3 py-2 rounded-md text-cool-gray-900 placeholder-cool-gray-500 focus:outline-none focus:placeholder-cool-gray-400 sm:text-sm"
              placeholder="Search" 
              type="search">
          </div>
        </form>
      </div>

      <!-- notifications -->
      <div class="ml-4 flex items-center md:ml-6">
        <button
          class="p-1 text-cool-gray-400 rounded-full hover:bg-cool-gray-100 hover:text-cool-gray-500 focus:outline-none focus:shadow-outline focus:text-cool-gray-500"
          aria-label="Notifications"
        >
          <svg 
            class="h-6 w-6" 
            stroke="currentColor" 
            fill="none" 
            viewBox="0 0 24 24"
          >
            <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2"
              d="M15 17h5l-1.405-1.405A2.032 2.032 0 0118 14.158V11a6.002 6.002 0 00-4-5.659V5a2 2 0 10-4 0v.341C7.67 6.165 6 8.388 6 11v3.159c0 .538-.214 1.055-.595 1.436L4 17h5m6 0v1a3 3 0 11-6 0v-1m6 0H9" 
            />
          </svg>
        </button>

        <!-- Profile dropdown -->
        <div class="ml-3 relative" @click="showUserDropdown = !showUserDropdown">
          <div>
            <button
              class="max-w-xs flex items-center text-sm rounded-full focus:outline-none focus:bg-cool-gray-100 lg:p-2 lg:rounded-md lg:hover:bg-cool-gray-100"
              id="user-menu"
              aria-label="User menu" 
              aria-haspopup="true"
            >
              <img 
                class="h-8 w-8 rounded-full"
                src="https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=facearea&facepad=2&w=256&h=256&q=80"
                alt=""
              >
              <p class="hidden ml-3 text-cool-gray-700 text-sm leading-5 font-medium lg:block">Adenuga Tunmise</p>
              <svg 
                class="hidden flex-shrink-0 ml-1 h-5 w-5 text-cool-gray-400 lg:block" 
                viewBox="0 0 20 20"
                fill="currentColor"
              >
                <path 
                  fill-rule="evenodd"
                  d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"
                  clip-rule="evenodd" 
                />
              </svg>
            </button>
          </div>

          <div class="origin-top-right absolute right-0 mt-2 w-48 rounded-md shadow-lg" v-show="showUserDropdown">
            <div 
              class="py-1 rounded-md bg-white shadow-xs" 
              role="menu" 
              aria-orientation="vertical"
              aria-labelledby="user-menu"
            >
              <a 
                href="#"
                class="block px-4 py-2 text-sm text-cool-gray-700 hover:bg-cool-gray-100 transition ease-in-out duration-150"
                role="menuitem"
              >
                Your Profile
              </a>
              <a 
                href="#"
                class="block px-4 py-2 text-sm text-cool-gray-700 hover:bg-cool-gray-100 transition ease-in-out duration-150"
                role="menuitem"
              >
                Settings
              </a>
              <a 
                href="#"
                class="block px-4 py-2 text-sm text-cool-gray-700 hover:bg-cool-gray-100 transition ease-in-out duration-150"
                role="menuitem"
              >
                Logout
              </a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  data() {
    return {
      showUserDropdown: false
    }
  },
}
</script>