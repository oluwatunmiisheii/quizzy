<template>
  <div class="w-full px-2 md:w-1/4">
    <div class="shadow-lg overflow-hidden h-full relative flex flex-col rounded">
      <img class="h-48 w-full object-cover" :src="quizCategory.category_image" alt="Sunset in the mountains">
      <div class="flex flex-col flex-auto px-6 py-4">
        <div class="font-bold text-xl mb-2">{{ quizCategory.category }}</div>
        <p class="text-gray-700 text-base">{{ quizCategory.description }}</p>
        <div class="mt-auto pt-5">
          <span 
            v-for="(subCategory, index) in quizCategory.subCategories"
            :key="index"
            class="inline-block bg-gray-200 rounded-full px-3 py-1 text-sm font-semibold text-gray-700 mr-2 mb-2"
          >#{{ subCategory }}
          </span>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    quizCategory: {
      type: Object,
      default:() => {}
    }
  }
}
</script>