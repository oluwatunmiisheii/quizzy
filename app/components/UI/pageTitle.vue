<template>
  <div class="flex flex-shrink-0 flex-wrap justify-between pt-20 items-center">
    <slot name='header-left' />
    <div>
      <h4>{{new Date() | moment("dddd, MMMM Do YYYY") }}</h4>
    </div>
  </div>
</template>

<style>


</style>
