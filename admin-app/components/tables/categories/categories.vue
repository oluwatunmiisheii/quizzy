<template>
  <div class="hidden sm:block">
    <div class="flex flex-col">
      <div class="align-middle min-w-full overflow-x-auto shadow overflow-hidden sm:rounded-lg">
        <table class="min-w-full divide-y divide-gray-200">
          <thead>
            <tr>
              <th class="px-6 py-3 bg-gray-50 text-left text-xs leading-4 font-medium text-gray-500 uppercase tracking-wider">
                Title
              </th>
              <th class="px-6 py-3 bg-gray-50 text-left text-xs leading-4 font-medium text-gray-500 uppercase tracking-wider">
                Status
              </th>
              <th class="px-6 py-3 bg-gray-50 text-left text-xs leading-4 font-medium text-gray-500 uppercase tracking-wider">
                Date created
              </th>
              <th class="px-6 py-3 bg-gray-50"></th>
            </tr>
          </thead>

          <tbody class="bg-white divide-y divide-gray-200">
            <tr>
              <td class="px-6 py-4 whitespace-no-wrap">
                <div class="flex items-center">
                  <div class="flex-shrink-0 h-10 w-10">
                    <img 
                      class="h-10 w-10 rounded-full"
                      src="https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                      alt=""
                    >
                  </div>
                  <div class="ml-4">
                    <div class="text-sm leading-5 font-medium text-gray-900">Movies</div>
                    <div class="text-sm leading-5 text-gray-500">20 questions</div>
                  </div>
                </div>
              </td>
              <td class="px-6 py-4 whitespace-no-wrap">
                <span class="px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-green-100 text-green-800">
                  Active
                </span>
              </td>
              <td class="px-6 py-4 whitespace-no-wrap text-sm leading-5 text-gray-500">
                12/02/2020
              </td>
              <td class="px-6 py-4 whitespace-no-wrap text-right text-sm leading-5 font-medium">
                <div class="flex">
                  <span class="hidden sm:block shadow-sm rounded-md"><ViewBtn /></span>
                  <span class="hidden sm:block ml-3 shadow-sm rounded-md"><EditBtn /></span>
                  <span class="hidden sm:block ml-3 shadow-sm rounded-md"><DeleteBtn /></span>
                </div>
              </td>
            </tr>
             <tr>
              <td class="px-6 py-4 whitespace-no-wrap">
                <div class="flex items-center">
                  <div class="flex-shrink-0 h-10 w-10">
                    <img 
                      class="h-10 w-10 rounded-full"
                      src="https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                      alt=""
                    >
                  </div>
                  <div class="ml-4">
                    <div class="text-sm leading-5 font-medium text-gray-900">Movies</div>
                    <div class="text-sm leading-5 text-gray-500">20 questions</div>
                  </div>
                </div>
              </td>
              <td class="px-6 py-4 whitespace-no-wrap">
                <span class="px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-green-100 text-green-800">
                  Active
                </span>
              </td>
              <td class="px-6 py-4 whitespace-no-wrap text-sm leading-5 text-gray-500">
                12/02/2020
              </td>
              <td class="px-6 py-4 whitespace-no-wrap text-right text-sm leading-5 font-medium">
                <div class="flex">
                  <span class="hidden sm:block shadow-sm rounded-md"><ViewBtn /></span>
                  <span class="hidden sm:block ml-3 shadow-sm rounded-md"><EditBtn /></span>
                  <span class="hidden sm:block ml-3 shadow-sm rounded-md"><DeleteBtn /></span>
                </div>
              </td>
            </tr>
             <tr>
              <td class="px-6 py-4 whitespace-no-wrap">
                <div class="flex items-center">
                  <div class="flex-shrink-0 h-10 w-10">
                    <img 
                      class="h-10 w-10 rounded-full"
                      src="https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                      alt=""
                    >
                  </div>
                  <div class="ml-4">
                    <div class="text-sm leading-5 font-medium text-gray-900">Movies</div>
                    <div class="text-sm leading-5 text-gray-500">20 questions</div>
                  </div>
                </div>
              </td>
              <td class="px-6 py-4 whitespace-no-wrap">
                <span class="px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-green-100 text-green-800">
                  Active
                </span>
              </td>
              <td class="px-6 py-4 whitespace-no-wrap text-sm leading-5 text-gray-500">
                12/02/2020
              </td>
              <td class="px-6 py-4 whitespace-no-wrap text-right text-sm leading-5 font-medium">
                <div class="flex">
                  <span class="hidden sm:block shadow-sm rounded-md"><ViewBtn /></span>
                  <span class="hidden sm:block ml-3 shadow-sm rounded-md"><EditBtn /></span>
                  <span class="hidden sm:block ml-3 shadow-sm rounded-md"><DeleteBtn /></span>
                </div>
              </td>
            </tr>
             <tr>
              <td class="px-6 py-4 whitespace-no-wrap">
                <div class="flex items-center">
                  <div class="flex-shrink-0 h-10 w-10">
                    <img 
                      class="h-10 w-10 rounded-full"
                      src="https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                      alt=""
                    >
                  </div>
                  <div class="ml-4">
                    <div class="text-sm leading-5 font-medium text-gray-900">Movies</div>
                    <div class="text-sm leading-5 text-gray-500">20 questions</div>
                  </div>
                </div>
              </td>
              <td class="px-6 py-4 whitespace-no-wrap">
                <span class="px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-green-100 text-green-800">
                  Active
                </span>
              </td>
              <td class="px-6 py-4 whitespace-no-wrap text-sm leading-5 text-gray-500">
                12/02/2020
              </td>
              <td class="px-6 py-4 whitespace-no-wrap text-right text-sm leading-5 font-medium">
                <div class="flex">
                  <span class="hidden sm:block shadow-sm rounded-md"><ViewBtn /></span>
                  <span class="hidden sm:block ml-3 shadow-sm rounded-md"><EditBtn /></span>
                  <span class="hidden sm:block ml-3 shadow-sm rounded-md"><DeleteBtn /></span>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
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
</template>

<script>
import ViewBtn from '@/components/actionIcons/view'
import EditBtn from '@/components/actionIcons/edit'
import DeleteBtn from '@/components/actionIcons/delete'
export default {
  components: {
    ViewBtn,
    EditBtn,
    DeleteBtn
  }
}
</script>
