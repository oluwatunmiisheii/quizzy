<template>
  <div>
    <AppPageTitle>
      <div slot="header-left">
        <h4 class="text-2xl">Leaderboard</h4>
        <p class="text-gray-700 text-base">Select a category to get started</p>
      </div>
    </AppPageTitle>

    <section class="section-padding mt-6">
      <table class="table-auto w-full">
        <thead>
          <tr>
            <th class="px-4 py-2">Title</th>
            <th class="px-4 py-2">Author</th>
            <th class="px-4 py-2">Views</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td class="border px-4 py-2">Intro to CSS</td>
            <td class="border px-4 py-2">Adam</td>
            <td class="border px-4 py-2">858</td>
          </tr>
          <tr class="bg-gray-100">
            <td class="border px-4 py-2">A Long and Winding Tour of the History of UI Frameworks and Tools and the Impact on Design</td>
            <td class="border px-4 py-2">Adam</td>
            <td class="border px-4 py-2">112</td>
          </tr>
          <tr>
            <td class="border px-4 py-2">Intro to JavaScript</td>
            <td class="border px-4 py-2">Chris</td>
            <td class="border px-4 py-2">1,280</td>
          </tr>
        </tbody>
      </table>
    </section>
  </div>
</template>