<template>
  <div>
    <modal name="register" :clickToClose="false" :adaptive="true">
      <div slot="top-right">
        <button @click="$modal.hide('register')">&times;</button>
      </div>
      <div class="p-4">
        <div class="mb-5">
          <h4>Create an account</h4>
          <p>Fill the form below to create an account</p>
        </div>
        <form class="w-full">
          <!-- full name field -->
          <div class="flex flex-wrap -mx-3 mb-6">
            <div class="w-full md:w-1/2 px-3 mb-6 md:mb-0">
              <label class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2" for="grid-first-name">Full Name</label>
              <input
                class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
                id="grid-last-name" 
                type="text" 
                placeholder="John Doe"
              >
              <!-- <p class="text-red-500 text-xs italic">Please fill out this field.</p> -->
            </div>

            <!-- uername field -->
            <div class="w-full md:w-1/2 px-3">
              <label 
                class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2"
                for="grid-user-name"
              >
                Username
              </label>
              <input
                class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
                id="grid-user-name" 
                type="text" 
                placeholder="Tunmii"
              >
            </div>
          </div>

          <div class="flex flex-wrap -mx-3 mb-6">
            <!-- email field -->
            <div class="w-full md:w-1/2 px-3 mb-6 md:mb-0">
              <label class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2" for="grid-email">Email</label>
              <input
                class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
                id="grid-email" 
                type="email" 
                placeholder="doe@email.com"
              >
            </div>
            <!-- password field -->
            <div class="w-full px-3 md:w-1/2 mb-6 md:mb-0">
              <label class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2" for="grid-password">Password</label>
              <input
                class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 mb-3 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
                id="grid-password" 
                type="password" 
                placeholder="******************"
              >
            </div>
          </div>

          <!-- action button -->
          <div class="flex items-center justify-between">
            <button
              class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline"
              type="button"
            >
              Sign Up
            </button>
            <a class="inline-block align-baseline font-bold text-sm text-blue-500 hover:text-blue-800" href="#">
              Forgot Password?
            </a>
          </div>
        </form>
      </div>
    </modal>
  </div>
</template>

<style scoped>
  .vm--top-right-slot {
    right: 30px !important;
  }

  .vm--top-right-slot button {
    font-size: 30px !important;
  }
</style>
