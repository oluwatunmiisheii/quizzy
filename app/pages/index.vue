<template>
  <section class="section-padding">
    <div class="flex -mx-2 flex-wrap mt-6">
      <MovieCategories v-for="(quizCategory,index) in quizCategories" :key="index" :quizCategory='quizCategory' />
    </div>
  </section>
</template>

<script>
import MovieCategories from '@/components/MovieCategory'
export default {
  components: {
    MovieCategories
  },
  data() {
    return {
      quizCategories: [
        {
          category: 'Movies',
          category_image: 'https://tailwindcss.com/img/card-top.jpg',
          description: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque, exercitationem praesentium nihil.',
          subCategories: ['Hollywood', 'Nollywood', 'Series']
        },
        {
          category: 'Sports',
          category_image: 'https://tailwindcss.com/img/card-top.jpg',
          description: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque, exercitationem praesentium nihil.',
          subCategories: ['Football', 'Basketball', 'Tennis']
        },
        {
          category: 'Places',
          category_image: 'https://tailwindcss.com/img/card-top.jpg',
          description: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque, exercitationem praesentium nihil.',
          subCategories: ['Europe','South America', 'Asia', 'North America', 'Africa']
        },
        {
          category: 'Music',
          category_image: 'https://tailwindcss.com/img/card-top.jpg',
          description: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque, exercitationem praesentium nihil.',
          subCategories: ['Rock','Hip Hop', 'Blues', 'Country Music', 'R & B']
        }
      ]
    }
  },
}
</script>

<style>
</style>
