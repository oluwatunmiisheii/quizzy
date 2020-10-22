<template>
  <div class="flex flex-shrink-0 flex-wrap justify-between pt-12 items-center">
    <slot name='header-left' />
    <div>
      <h4>{{new Date() | moment("dddd, MMMM Do YYYY") }}</h4>
    </div>
  </div>
</template>

<style>
 /* .card {
   @apply bg-grey-200 text-grey-800;
  } */
</style>
