<template>
  <div class="bg-white overflow-hidden shadow rounded-lg">
    <div class="px-4 py-5 sm:p-6">
      <div class="flex items-center">
        <div class="flex-shrink-0 bg-indigo-500 rounded-md p-3">
          <slot />
        </div>
        <div class="ml-5 w-0 flex-1">
          <dl>
            <dt class="text-sm leading-5 font-medium text-cool-gray-500 truncate">
              {{heading}}
            </dt>
            <dd class="flex items-baseline">
              <div class="text-2xl leading-8 font-semibold text-cool-gray-900">
                {{count}}
              </div>
            </dd>
          </dl>
        </div>
      </div>
    </div>
    <div class="bg-cool-gray-50 px-4 py-4 sm:px-6">
      <div class="text-sm leading-5">
        <a href="#" class="font-medium text-indigo-600 hover:text-indigo-500 transition ease-in-out duration-150">
          {{ctaText}}
        </a>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    props: {
      heading: {
        type: String,
        default: () => '',
        required: true
      },
      count: {
        type: Number,
        default: () => 0,
        required: true
      },
      ctaText: {
        type: String,
        default: () => '',
        required: true
      },
    }
  }

</script>
