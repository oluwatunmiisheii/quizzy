<template>
  <div>
    <page-header />
    <div class="mt-8 max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
      <div class="flex items-center">
        <h2 class="text-lg leading-6 font-medium text-cool-gray-900 mr-2">Leaderboard for</h2> 
        <div>
          <!-- <label for="location" class="block text-sm leading-5 font-medium text-gray-700">Location</label> -->
          <select 
            id="location" 
            class="mt-1 form-select block w-full pl-3 pr-10 py-2 text-base leading-6 border-gray-300 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 sm:text-sm sm:leading-5"
          >
            <option>USA</option>
            <option selected>Canada</option>
            <option>EU</option>
          </select>
        </div>
      </div>

      <!-- leaderboard -->
      <ul class="grid grid-cols-1 gap-5 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 mt-5">
        <li class="col-span-1 flex flex-col text-center bg-white rounded-lg shadow">
          <div class="flex-1 flex flex-col p-8">
            <span
              class="inline-flex items-center justify-center h-20 w-20 rounded-full mx-auto flex-shrink-0 bg-red-600">
              <span class="text-base font-medium leading-none text-white">TW</span>
            </span>
            <h3 class="mt-6 text-gray-900 text-sm leading-5 font-medium">Jane Cooper</h3>
            <dl class="mt-1 flex-grow flex flex-col justify-between">
              <dt class="sr-only">Title</dt>
              <dd class="text-gray-500 text-sm leading-5">Paradigm Representative</dd>
              <dt class="sr-only">Role</dt>
              <dd class="mt-3">
                <span
                  class="px-2 py-1 text-teal-800 text-xs leading-4 font-medium bg-teal-100 rounded-full">1st position</span>
              </dd>
            </dl>
          </div>
          <div class="border-t border-gray-200">
            <div class="-mt-px flex">
              <div class="w-0 flex-1 flex border-r border-gray-200">
                <a href="#"
                  class="relative -mr-px w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-bl-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150">
                  <!-- Heroicon name: mail -->
                  <svg class="w-5 h-5 text-gray-400" viewBox="0 0 20 20" fill="currentColor">
                    <path d="M2.003 5.884L10 9.882l7.997-3.998A2 2 0 0016 4H4a2 2 0 00-1.997 1.884z" />
                    <path d="M18 8.118l-8 4-8-4V14a2 2 0 002 2h12a2 2 0 002-2V8.118z" />
                  </svg>
                  <span class="ml-3">Email</span>
                </a>
              </div>
              <div class="-ml-px w-0 flex-1 flex">
                <a href="#"
                  class="relative w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-br-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150">
                  <!-- Heroicon name: phone -->
                  <svg class="w-5 h-5 text-gray-400" viewBox="0 0 20 20" fill="currentColor">
                    <path
                      d="M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z" />
                  </svg>
                  <span class="ml-3">Call</span>
                </a>
              </div>
            </div>
          </div>
        </li>

        <li class="col-span-1 flex flex-col text-center bg-white rounded-lg shadow">
          <div class="flex-1 flex flex-col p-8">
            <span
              class="inline-flex items-center justify-center h-20 w-20 rounded-full mx-auto flex-shrink-0 bg-blue-600">
              <span class="text-base font-medium leading-none text-white">TW</span>
            </span>
            <h3 class="mt-6 text-gray-900 text-sm leading-5 font-medium">Jane Cooper</h3>
            <dl class="mt-1 flex-grow flex flex-col justify-between">
              <dt class="sr-only">Title</dt>
              <dd class="text-gray-500 text-sm leading-5">Paradigm Representative</dd>
              <dt class="sr-only">Role</dt>
              <dd class="mt-3">
                <span
                  class="px-2 py-1 text-teal-800 text-xs leading-4 font-medium bg-teal-100 rounded-full">2nd position</span>
              </dd>
            </dl>
          </div>
          <div class="border-t border-gray-200">
            <div class="-mt-px flex">
              <div class="w-0 flex-1 flex border-r border-gray-200">
                <a href="#"
                  class="relative -mr-px w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-bl-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150">
                  <!-- Heroicon name: mail -->
                  <svg class="w-5 h-5 text-gray-400" viewBox="0 0 20 20" fill="currentColor">
                    <path d="M2.003 5.884L10 9.882l7.997-3.998A2 2 0 0016 4H4a2 2 0 00-1.997 1.884z" />
                    <path d="M18 8.118l-8 4-8-4V14a2 2 0 002 2h12a2 2 0 002-2V8.118z" />
                  </svg>
                  <span class="ml-3">Email</span>
                </a>
              </div>
              <div class="-ml-px w-0 flex-1 flex">
                <a href="#"
                  class="relative w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-br-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150">
                  <!-- Heroicon name: phone -->
                  <svg class="w-5 h-5 text-gray-400" viewBox="0 0 20 20" fill="currentColor">
                    <path
                      d="M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z" />
                  </svg>
                  <span class="ml-3">Call</span>
                </a>
              </div>
            </div>
          </div>
        </li>

        <li class="col-span-1 flex flex-col text-center bg-white rounded-lg shadow">
          <div class="flex-1 flex flex-col p-8">
            <span
              class="inline-flex items-center justify-center h-20 w-20 rounded-full mx-auto flex-shrink-0 bg-pink-600">
              <span class="text-base font-medium leading-none text-white">TW</span>
            </span>
            <h3 class="mt-6 text-gray-900 text-sm leading-5 font-medium">Jane Cooper</h3>
            <dl class="mt-1 flex-grow flex flex-col justify-between">
              <dt class="sr-only">Title</dt>
              <dd class="text-gray-500 text-sm leading-5">Paradigm Representative</dd>
              <dt class="sr-only">Role</dt>
              <dd class="mt-3">
                <span
                  class="px-2 py-1 text-teal-800 text-xs leading-4 font-medium bg-teal-100 rounded-full">3rd position</span>
              </dd>
            </dl>
          </div>
          <div class="border-t border-gray-200">
            <div class="-mt-px flex">
              <div class="w-0 flex-1 flex border-r border-gray-200">
                <a href="#"
                  class="relative -mr-px w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-bl-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150">
                  <!-- Heroicon name: mail -->
                  <svg class="w-5 h-5 text-gray-400" viewBox="0 0 20 20" fill="currentColor">
                    <path d="M2.003 5.884L10 9.882l7.997-3.998A2 2 0 0016 4H4a2 2 0 00-1.997 1.884z" />
                    <path d="M18 8.118l-8 4-8-4V14a2 2 0 002 2h12a2 2 0 002-2V8.118z" />
                  </svg>
                  <span class="ml-3">Email</span>
                </a>
              </div>
              <div class="-ml-px w-0 flex-1 flex">
                <a href="#"
                  class="relative w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-br-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150">
                  <!-- Heroicon name: phone -->
                  <svg class="w-5 h-5 text-gray-400" viewBox="0 0 20 20" fill="currentColor">
                    <path
                      d="M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z" />
                  </svg>
                  <span class="ml-3">Call</span>
                </a>
              </div>
            </div>
          </div>
        </li>

        <!-- current user clicked -->
        <div class="flex flex-col text-center bg-white rounded-lg shadow">
          <div class="flex-1 flex flex-col p-8">
            <span
              class="inline-flex items-center justify-center h-20 w-20 rounded-full mx-auto flex-shrink-0 bg-purple-800">
              <span class="text-base font-medium leading-none text-white">TW</span>
            </span>
            <h3 class="mt-6 text-gray-900 text-sm leading-5 font-medium">Jane Cooper</h3>
            <dl class="mt-1 flex-grow flex flex-col justify-between">
              <dt class="sr-only">Title</dt>
              <dd class="text-gray-500 text-sm leading-5">Paradigm Representative</dd>
              <dt class="sr-only">Role</dt>
              <dd class="mt-3">
                <span
                  class="px-2 py-1 text-teal-800 text-xs leading-4 font-medium bg-teal-100 rounded-full">4th position</span>
              </dd>
            </dl>
          </div>
          <div class="border-t border-gray-200">
            <div class="-mt-px flex">
              <div class="w-0 flex-1 flex border-r border-gray-200">
                <a href="#"
                  class="relative -mr-px w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-bl-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150">
                  <!-- Heroicon name: mail -->
                  <svg class="w-5 h-5 text-gray-400" viewBox="0 0 20 20" fill="currentColor">
                    <path d="M2.003 5.884L10 9.882l7.997-3.998A2 2 0 0016 4H4a2 2 0 00-1.997 1.884z" />
                    <path d="M18 8.118l-8 4-8-4V14a2 2 0 002 2h12a2 2 0 002-2V8.118z" />
                  </svg>
                  <span class="ml-3">Email</span>
                </a>
              </div>
              <div class="-ml-px w-0 flex-1 flex">
                <a href="#"
                  class="relative w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-br-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150"
                >
                  <!-- Heroicon name: phone -->
                  <svg class="w-5 h-5 text-gray-400" viewBox="0 0 20 20" fill="currentColor">
                    <path
                      d="M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z" 
                    />
                  </svg>
                  <span class="ml-3">Call</span>
                </a>
              </div>
            </div>
          </div>
        </div>
      </ul>

      <div class="mt-10 grid grid-cols-1 gap-5 sm:grid-cols-1 lg:grid-cols-4">
        <div class="col-start-1 col-end-4">
         <h2 class="text-lg leading-6 font-medium text-cool-gray-900 mr-2">All time Best (Hall of Famers)</h2> 
        </div>
        <div class="col-end-5">
          <label for="location" class="block text-sm leading-5 font-medium text-gray-700">Location</label>
          <select 
            id="location" 
            class="mt-1 form-select block w-full pl-3 pr-10 py-2 text-base leading-6 border-gray-300 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 sm:text-sm sm:leading-5"
          >
            <option>USA</option>
            <option selected>Canada</option>
            <option>EU</option>
          </select>
        </div>
      </div>
      <div class="mt-5 grid grid-cols-1 gap-5 sm:grid-cols-1 lg:grid-cols-4">
        <LeaderBoard :className="'col-start-1 col-end-4'" />
        <li class="col-span-1 flex flex-col text-center bg-white rounded-lg shadow">
    <div class="flex-1 flex flex-col p-8">
      <img class="w-32 h-32 flex-shrink-0 mx-auto bg-black rounded-full" src="https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60" alt="">
      <h3 class="mt-6 text-gray-900 text-sm leading-5 font-medium">Jane Cooper</h3>
      <dl class="mt-1 flex-grow flex flex-col justify-between">
        <dt class="sr-only">Title</dt>
        <dd class="text-gray-500 text-sm leading-5">Paradigm Representative</dd>
        <dt class="sr-only">Role</dt>
        <dd class="mt-3">
          <span class="px-2 py-1 text-teal-800 text-xs leading-4 font-medium bg-teal-100 rounded-full">Admin</span>
        </dd>
      </dl>
    </div>
    <div class="border-t border-gray-200">
      <div class="-mt-px flex">
        <div class="w-0 flex-1 flex border-r border-gray-200">
          <a href="#" class="relative -mr-px w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-bl-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150">
            <!-- Heroicon name: mail -->
            <svg class="w-5 h-5 text-gray-400" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor">
              <path d="M2.003 5.884L10 9.882l7.997-3.998A2 2 0 0016 4H4a2 2 0 00-1.997 1.884z" />
              <path d="M18 8.118l-8 4-8-4V14a2 2 0 002 2h12a2 2 0 002-2V8.118z" />
            </svg>
            <span class="ml-3">Email</span>
          </a>
        </div>
        <div class="-ml-px w-0 flex-1 flex">
          <a href="#" class="relative w-0 flex-1 inline-flex items-center justify-center py-4 text-sm leading-5 text-gray-700 font-medium border border-transparent rounded-br-lg hover:text-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 focus:z-10 transition ease-in-out duration-150">
            <!-- Heroicon name: phone -->
            <svg class="w-5 h-5 text-gray-400" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor">
              <path d="M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z" />
            </svg>
            <span class="ml-3">Call</span>
          </a>
        </div>
      </div>
    </div>
  </li>

       </div>
    </div>
  </div>
</template>

<script>
  import LeaderBoard from '@/components/tables/dashboard/leaderboard'
  export default {
    components: {
      LeaderBoard
    }
  }

</script>

<style>

</style>
