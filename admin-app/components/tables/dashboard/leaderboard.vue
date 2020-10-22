<template>
  <div :class="className">
    <!-- Activity table (small breakopoint and up) -->
    <div class="hidden sm:block">
      <div class="flex flex-col mt-2">
        <div class="align-middle min-w-full overflow-x-auto shadow overflow-hidden sm:rounded-lg">
          <table class="min-w-full divide-y divide-cool-gray-200">
            <thead>
              <tr>
                <th
                  class="pl-6 pr-3 py-3 bg-cool-gray-50 text-left text-xs leading-4 font-medium text-cool-gray-500 uppercase tracking-wider">
                  Rank
                </th>
                <th
                  class="px-6 py-3 bg-cool-gray-50 text-left text-xs leading-4 font-medium text-cool-gray-500 uppercase tracking-wider">
                  Username
                </th>
                <th
                  class="px-6 py-3 bg-cool-gray-50 text-left text-xs leading-4 font-medium text-cool-gray-500 uppercase tracking-wider">
                  Score
                </th>
              </tr>
            </thead>
            <tbody class="bg-white divide-y divide-cool-gray-200">
              <tr class="bg-white">
                <td class="pl-6 pr-3 py-4 whitespace-no-wrap text-left text-sm leading-5 text-cool-gray-500 font-medium">
                  1
                </td>
                <td class="max-w-0 px-6 py-4 whitespace-no-wrap text-sm leading-5 text-cool-gray-900">
                  <div class="text-sm leading-5 font-medium text-gray-900">Adenuga Tunmise</div>
                  <div class="text-sm leading-5 text-gray-500">Tunmise@gmail.com</div>
                </td>
                <td class="px-6 py-4 whitespace-no-wrap text-left text-sm leading-5 text-cool-gray-500 font-medium">
                  90% 
                </td>
              </tr>

              <!-- More rows... -->
            </tbody>
          </table>
          <!-- Pagination -->
          <nav class="bg-white px-4 py-3 flex items-center justify-between border-t border-cool-gray-200 sm:px-6">
            <div class="hidden sm:block">
              <p class="text-sm leading-5 text-cool-gray-700">
                Showing
                <span class="font-medium">1</span>
                to
                <span class="font-medium">10</span>
                of
                <span class="font-medium">20</span>
                results
              </p>
            </div>
            <div class="flex-1 flex justify-between sm:justify-end">
              <a href="#"
                class="relative inline-flex items-center px-4 py-2 border border-cool-gray-300 text-sm leading-5 font-medium rounded-md text-cool-gray-700 bg-white hover:text-cool-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 active:bg-cool-gray-100 active:text-cool-gray-700 transition ease-in-out duration-150">
                Previous
              </a>
              <a href="#"
                class="ml-3 relative inline-flex items-center px-4 py-2 border border-cool-gray-300 text-sm leading-5 font-medium rounded-md text-cool-gray-700 bg-white hover:text-cool-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 active:bg-cool-gray-100 active:text-cool-gray-700 transition ease-in-out duration-150">
                Next
              </a>
            </div>
          </nav>
        </div>
      </div>
    </div>

    <!-- No leaderboard view -->

  </div>
</template>

<script>
export default {
  props: {
    className: {
      type: String,
      default: () => ''
    }
  }
}
</script>
